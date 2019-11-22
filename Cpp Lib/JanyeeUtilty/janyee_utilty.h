#pragma once
#include "pch.h"

/*
接收一个长度 length，返回长度为 length 的随机字符串
*/
__declspec(dllexport) std::string random_string(std::string::size_type length);

__declspec(dllexport) int getSizeOfStringStream(std::stringstream& oss);

__declspec(dllexport) std::wstring utf8ToUtf16(const std::string& utf8Str);

__declspec(dllexport) std::string utf16ToUtf8(const std::wstring& utf16Str);