#pragma once
#include <locale>
#include <codecvt>
#include <Windows.h>
#include <memory>

#define Windows_Platform true

namespace Janyee
{
    static struct Utilty
    {
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

