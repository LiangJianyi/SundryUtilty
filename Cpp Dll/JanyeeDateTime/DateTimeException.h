#pragma once
#include <errno.h>
#include <iostream>
#include <string>
#include "Utilty.h"

namespace Janyee
{
	class DateTimeException :public std::runtime_error
	{
		std::wstring message;
	public:
		DateTimeException() :runtime_error("Unknown error.") {};
		DateTimeException(std::wstring const& msg) :message(msg), runtime_error(Utilty::WstringToString(msg)) {}
	};
}

