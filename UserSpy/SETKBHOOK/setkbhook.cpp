#include "pch.h"
#include "framework.h"
#include "setkbhook.h"

extern "C" SETKBHOOK_API void StartMonitKeys(char* whereToWriteKeys, char* whereToWriteWords, char* whereToReadBadWords) {

	KBHook kbHookLib;

	kbHookLib.LoadDll();

	kbHookLib.SetWhereToWriteKeys(whereToWriteKeys);
	kbHookLib.SetWhereToWriteWords(whereToWriteWords);
	kbHookLib.SetWhereToReadBadWords(whereToReadBadWords);

	kbHookLib.SetKeyBoardHook();

	kbHookLib.Run();
}

bool KBHook::LoadDll()
{
	try {
		_hDLL = LoadLibraryA("KBHOOKPROC.dll");
	}
	catch (...) {
		return false;
	}
	return true;
}

bool KBHook::SetWhereToWriteKeys(char* keysReportPath)
{
	return SendStrToDllFunction(keysReportPath, "SetStatsPath");
}
bool KBHook::SetWhereToWriteWords(char* wordsReportPath)
{
	return SendStrToDllFunction(wordsReportPath, "SetModPath");
}
bool KBHook::SetWhereToReadBadWords(char* badWordsSourcePath)
{
	return SendStrToDllFunction(badWordsSourcePath, "SetBadWordsPath");
}

bool KBHook::SetKeyBoardHook()
{
	if (!_hDLL)
		return false;

	try {
		HOOKPROC keyProcFunct = (HOOKPROC)GetProcAddress(_hDLL, "KeyboardProc");

		if (!keyProcFunct)
			return false;

		_hhookSysMsg = SetWindowsHookExA(WH_KEYBOARD, keyProcFunct, _hDLL, 0);
	}
	catch (...) {
		return false;
	}

	return true;
}

void KBHook::Run()
{
	if (!_hhookSysMsg)
		return;

	MSG msg = { 0 };
	while (GetMessageA(&msg, 0, 0, 0));
}

KBHook::~KBHook()
{
	if (_hhookSysMsg)
		UnhookWindowsHookEx(_hhookSysMsg);

	if (_hDLL)
		FreeLibrary(_hDLL);
}

bool KBHook::SendStrToDllFunction(char * str, const char * dllFunctName)
{
	if (!_hDLL)
		return false;

	try {
		FNCVOIDSTR setStrFunct = (FNCVOIDSTR)GetProcAddress(_hDLL, dllFunctName);

		if (!setStrFunct)
			return false;

		setStrFunct(str);
	}
	catch (...) {
		return false;
	}

	return true;
}
