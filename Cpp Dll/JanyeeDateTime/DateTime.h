#pragma once
#include <chrono>
#include "DateTimeException.h"

namespace Janyee
{
	class DateTime
	{
		time_t _now;
		tm _tm;
		void CheckErrno(errno_t err);
	public:
		DateTime() :_now(std::chrono::system_clock::to_time_t(std::chrono::system_clock::now())), _tm() {
			CheckErrno(localtime_s(&_tm, &_now));
		}
		int Year() const;
		int Month() const;
		int DayOfMonth() const;
		int DayOfWeek() const;
		int DayOfYear() const;
		bool IsDaylightSavingTime() const;
		int Hour() const;
		int Minute() const;
		int Second() const;
	};
}

