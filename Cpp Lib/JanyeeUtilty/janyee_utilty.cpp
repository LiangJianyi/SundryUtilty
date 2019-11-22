#include "pch.h"
#include "janyee_utilty.h"

__declspec(dllexport) std::string random_string(std::string::size_type length) {
	static auto& chrs = "0123456789"
		"abcdefghijklmnopqrstuvwxyz"
		"ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	thread_local static std::mt19937 rg{ std::random_device{}() };
	thread_local static std::uniform_int_distribution<std::string::size_type> pick(0, sizeof(chrs) - 2);

	std::string s;
	s.reserve(length);
	while (length--) {
		s += chrs[pick(rg)];
	}
	return s;
}

// reference: https://stackoverflow.com/questions/4432793/size-of-stringstream
__declspec(dllexport) int getSizeOfStringStream(std::stringstream& oss) {
	oss.seekg(0, std::ios::end);
	int size = oss.tellg();
	return size;
}


// reference: https://codereview.stackexchange.com/questions/419/converting-between-stdwstring-and-stdstring
__declspec(dllexport) std::wstring stringToWstring(const std::string& utf8Str) {
	std::wstring_convert<std::codecvt_utf8_utf16<wchar_t>> conv;
	return conv.from_bytes(utf8Str);
}

__declspec(dllexport) std::string wstringToString(const std::wstring& utf16Str) {
	std::wstring_convert<std::codecvt_utf8_utf16<wchar_t>> conv;
	return conv.to_bytes(utf16Str);
}