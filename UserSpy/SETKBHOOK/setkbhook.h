#define SETKBHOOK_API __declspec(dllexport)

#ifndef SETKBHOOK_H_
#define SETKBHOOK_H_

#include<Windows.h>
#include<iostream>

extern "C" SETKBHOOK_API void StartMonitKeys(char* statsPath, char* modPath, char* badWords);

#endif 