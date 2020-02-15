#pragma once

#define Windows_Platform true

#if Windows_Platform == false
#include <locale>
#include <codecvt>  
#endif // Windows_Platform == false

#include <iostream>
#include <Windows.h>
#include <memory>
#include <string>
#include <random>

namespace Janyee
{
	struct Utilty
	{
		static std::string RandomString(std::string::size_type length) {
			static auto& chrs = "0123456789"
				"abcdefghijklmnopqrstuvwxyz"
				"ABCDEFGHIJKLMNOPQRSTUVWXYZ";

			thread_local static std::mt19937 rg { std::random_device{}() };
			thread_local static std::uniform_int_distribution<std::string::size_type> pick(0, sizeof(chrs) - 2);

			std::string s;
			s.reserve(length);
			while (length--) {
				s += chrs[pick(rg)];
			}
			return s;
		}

		static std::tuple<unsigned long long, unsigned short, unsigned short, unsigned short, unsigned short, unsigned short> RandomDate(
			std::tuple<std::uniform_int_distribution<unsigned long long>::result_type, std::uniform_int_distribution<unsigned long long>::result_type> years,
			std::tuple<std::uniform_int_distribution<unsigned short>::result_type, std::uniform_int_distribution<unsigned short>::result_type> months,
			std::tuple<std::uniform_int_distribution<unsigned short>::result_type, std::uniform_int_distribution<unsigned short>::result_type> days) {
			const unsigned int DOWN_LIMIT = 0;	// 表示随机数下限的元组成员索引
			const unsigned int UPPER_LIMIT = 1;	// 表示随机数上限的元组成员索引
			std::mt19937 gen { std::random_device{}() };
			auto year = std::uniform_int_distribution<unsigned long long>(std::get<DOWN_LIMIT>(years), std::get<UPPER_LIMIT>(years))(gen);
			auto month = std::uniform_int_distribution<unsigned short>(std::get<DOWN_LIMIT>(months), std::get<UPPER_LIMIT>(months))(gen);
			auto day = std::uniform_int_distribution<unsigned short>(std::get<DOWN_LIMIT>(days), std::get<UPPER_LIMIT>(days))(gen);
			auto hour = std::uniform_int_distribution<unsigned short>(0, 23)(gen);
			auto min = std::uniform_int_distribution<unsigned short>(0, 59)(gen);
			auto sec = std::uniform_int_distribution<unsigned short>(0, 59)(gen);
			return std::make_tuple(year, month, day, hour, min, sec);
		}

#if Windows_Platform
		/*
		https://stackoverflow.com/questions/6693010/how-do-i-use-multibytetowidechar
		*/
		static std::wstring StringToWstring(const std::string& s) {
			int wchars_num = MultiByteToWideChar(CP_UTF8, 0, s.c_str(), -1, NULL, 0);
			wchar_t* wstr = new wchar_t[wchars_num];
			MultiByteToWideChar(CP_UTF8, 0, s.c_str(), -1, wstr, wchars_num);
			return std::wstring(wstr);
		}

		static std::string WstringToString(const std::wstring& ws) {
			int charsNum = WideCharToMultiByte(CP_UTF8, 0, &ws.at(0), -1, NULL, 0, NULL, NULL);
			if (charsNum) {
				// 在Microsoft编译器中，wchar_t 表示16位宽的字符，用于存储编码为UTF-16LE（Windows操作系统上的本机字符类型）的Unicode
				CHAR* str = new CHAR[charsNum];
				if (WideCharToMultiByte(CP_UTF8, 0, &ws.at(0), -1, str, 0, NULL, NULL)) {
					return std::string(str);
				}
				else {
					DWORD errCode = GetLastError();
					switch (errCode) {
						case ERROR_INSUFFICIENT_BUFFER:
							throw std::runtime_error("A supplied buffer size was not large enough, or it was incorrectly set to NULL.");
						case ERROR_INVALID_FLAGS:
							throw std::runtime_error("The values supplied for flags were not valid.");
						case ERROR_INVALID_PARAMETER:
							throw std::runtime_error("Any of the parameter values was invalid. ");
						case ERROR_NO_UNICODE_TRANSLATION:
							throw std::runtime_error("Invalid Unicode was found in a string.");
						default:
							throw std::exception("Unkown error.");
					}
				}
			}
			else {
				DWORD errCode = GetLastError();
				switch (errCode) {
					case ERROR_INSUFFICIENT_BUFFER:
						throw std::runtime_error("A supplied buffer size was not large enough, or it was incorrectly set to NULL.");
					case ERROR_INVALID_FLAGS:
						throw std::runtime_error("The values supplied for flags were not valid.");
					case ERROR_INVALID_PARAMETER:
						throw std::runtime_error("Any of the parameter values was invalid. ");
					case ERROR_NO_UNICODE_TRANSLATION:
						throw std::runtime_error("Invalid Unicode was found in a string.");
					default:
						throw std::exception("Unkown error.");
				}
			}
		}
#else
		static std::wstring StringToWstring(const std::string& str) {
			using convert_typeX = std::codecvt_utf8<wchar_t>;
			std::wstring_convert<convert_typeX, wchar_t> converterX;

			return converterX.from_bytes(str);
		}

		static std::string WstringToString(const std::wstring& wstr) {
			using convert_typeX = std::codecvt_utf8<wchar_t>;
			std::wstring_convert<convert_typeX, wchar_t> converterX;

			return converterX.to_bytes(wstr);
		}
#endif
	};
}

