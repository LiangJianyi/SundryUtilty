#pragma once
#include <chrono>
#include <memory>
#include <map>
#include <vector>
#include "DateTimeException.h"

namespace Janyee
{
	enum class LocalTimeZone
	{
		ZH_CN,
		EN_US
	};

	class DateTime
	{
		time_t _now;
		tm _tm;
		int _year;
		int _month;
		int _dayOfMonth;
		int _dayOfWeek;
		int _dayOfYear;
		bool _isDaylightSavingTime;
		int _hour;
		int _minute;
		int _second;
		LocalTimeZone _localTimeZone;
		void CheckErrno(errno_t err);
		void SetYear(decltype(_year) const& year);
		void SetMonth(decltype(_month) const& month);
		void SetDayOfMonth(decltype(_dayOfMonth) const& dayOfMonth);
		void SetDayOfWeek(int const& year, int const& month, int const& day);
		void SetDayOfYear(int const& year, int const& month, int const& day);
		void SetHour(decltype(_hour) const& hour);
		void SetMinute(decltype(_minute) const& minute);
		void SetSecond(decltype(_second) const& second);
	public:
		DateTime() :_now(), _tm(),
			_year(1),
			_month(1),
			_dayOfMonth(1),
			_isDaylightSavingTime(std::make_shared<bool>(false)),
			_hour(0),
			_minute(0),
			_second(0),
			_localTimeZone(LocalTimeZone::ZH_CN) {
			CheckErrno(localtime_s(&_tm, &_now));
			SetDayOfWeek(_year, _month, _dayOfMonth);
			SetDayOfYear(_year, _month, _dayOfMonth);
		}
		DateTime(time_t const& time) :_now(time), _tm() {
			CheckErrno(localtime_s(&_tm, &_now));
			_year = _tm.tm_year + 1900;
			_month = _tm.tm_mon + 1;
			_dayOfMonth = _tm.tm_mday;
			_dayOfWeek = _tm.tm_wday;
			_dayOfYear = _tm.tm_yday + 1;
			_isDaylightSavingTime = _tm.tm_isdst,
			_hour = _tm.tm_hour;
			_minute = _tm.tm_min;
			_second = _tm.tm_sec;
			_localTimeZone = LocalTimeZone::ZH_CN;
		}
		DateTime(int const& year, int const& month, int const& day, int const& hour = 0, int const& minute = 0, int const& second = 0, bool const& dayLight = false, LocalTimeZone const& localTimeZone = LocalTimeZone::ZH_CN) :_now(), _tm(), _isDaylightSavingTime(std::make_shared<bool>(dayLight)) {
			CheckErrno(localtime_s(&_tm, &_now));
			SetYear(year);
			SetMonth(month);
			SetDayOfMonth(day);
			SetDayOfWeek(year, month, day);
			SetDayOfYear(year, month, day);
			SetHour(hour);
			SetMinute(minute);
			SetSecond(second);
			SetLocalTimeZone(localTimeZone);
		}
		DateTime(int const&& year, int const&& month, int const&& day, int const&& hour = 0, int const&& minute = 0, int const&& second = 0, bool const&& dayLight = false, LocalTimeZone const&& localTimeZone = LocalTimeZone::ZH_CN) :_now(), _tm(), _isDaylightSavingTime(std::make_shared<bool>(dayLight)) {
			CheckErrno(localtime_s(&_tm, &_now));
			SetYear(year);
			SetMonth(month);
			SetDayOfMonth(day);
			SetDayOfWeek(year, month, day);
			SetDayOfYear(year, month, day);
			SetHour(hour);
			SetMinute(minute);
			SetSecond(second);
			SetLocalTimeZone(localTimeZone);
		}
		static DateTime Now();
		int GetYear() const;
		int GetMonth() const;
		int GetDayOfMonth() const;
		int GetDayOfWeek() const;
		int GetDayOfYear() const;
		bool IsDaylightSavingTime() const;
		int GetHour() const;
		int GetMinute() const;
		int GetSecond() const;
		bool IsLeapYear() const;
		bool IsLeapYear(int year) const;
		void SetLocalTimeZone(LocalTimeZone const& local);
		LocalTimeZone GetLocalTimeZone() const;
		std::string ToString() const;
		std::string ToShortDate() const;
		std::string ToShortTime() const;
	};
}

