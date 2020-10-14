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

#endif