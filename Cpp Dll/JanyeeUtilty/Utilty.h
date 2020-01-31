#pragma once
#include <locale>
#include <codecvt>

namespace Janyee
{
    static struct Utilty
    {
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
    };
}

