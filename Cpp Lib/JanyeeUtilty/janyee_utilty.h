#pragma once
#include "pch.h"

/*
接收一个长度 length，返回长度为 length 的随机字符串
*/
__declspec(dllexport) std::string random_string(std::string::size_type length);