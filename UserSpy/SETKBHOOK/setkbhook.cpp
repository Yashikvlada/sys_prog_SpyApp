#include "pch.h"
#include "framework.h"
#include "setkbhook.h"

typedef void(*FNCSETSTR)(std::string);

extern "C" SETKBHOOK_API void StartMonitKeys(char* statsPath, char* modPath, char* badWords) {

	HHOOK hhookSysMsg = NULL;

	HINSTANCE hDLL = LoadLibraryA("KBHOOKPROC.dll");

	if (hDLL != NULL) {

		auto setStatsPath = (FNCSETSTR)GetProcAddress(hDLL, "SetStatsPath");
		setStatsPath(statsPath);
		auto setModPath = (FNCSETSTR)GetProcAddress(hDLL, "SetModPath");
		setModPath(modPath);
		auto setBadWords = (FNCSETSTR)GetProcAddress(hDLL, "SetBadWordsPath");
		setBadWords(badWords);


		auto hkprcSysMsg = (HOOKPROC)GetProcAddress(hDLL, "KeyboardProc");
		if (hkprcSysMsg != NULL) {

			hhookSysMsg = SetWindowsHookExA(WH_KEYBOARD, hkprcSysMsg, hDLL, 0);
		}
	}

	if (hhookSysMsg == NULL)
		return;

	MSG msg = { 0 };
	while (GetMessageA(&msg, 0, 0, 0));
}