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
			_dayOfWeek = _tm.tm_wday + 1;
			_dayOfYear = _tm.tm_yday + 1;
			_isDaylightSavingTime = false;
			_hour = _tm.tm_isdst;
			_minute = _tm.tm_hour;
			_second = _tm.tm_min;
			_localTimeZone = LocalTimeZone::ZH_CN;
		}
		DateTime(int year, int month, int day, int hour = 0, int minute = 0, int second = 0, bool dayLight = false, LocalTimeZone localTimeZone = LocalTimeZone::ZH_CN) :_now(), _tm(), _isDaylightSavingTime(std::make_shared<bool>(dayLight)) {
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
		int Year() const;
		int Month() const;
		int DayOfMonth() const;
		int DayOfWeek() const;
		int DayOfYear() const;
		bool IsDaylightSavingTime() const;
		int Hour() const;
		int Minute() const;
		int Second() const;
		bool IsLeapYear() const;
		bool IsLeapYear(int year) const;
		void SetLocalTimeZone(LocalTimeZone const& local) {
			_localTimeZone = local;
		}
		std::string ToString() const {
			const std::string yearString { std::to_string(Year()) };
			const std::string monthString { std::to_string(Month()) };
			const std::string dayOfMonthString { std::to_string(DayOfMonth()) };
			const std::string yearOfWeekString { std::to_string(DayOfWeek()) };
			const std::string hourString { std::to_string(Hour()) };
			const std::string minuteString { std::to_string(Minute()) };
			const std::string secondString { std::to_string(Second()) };
			auto WeekToString { [](int const& week)->std::string {
				switch (week) {
					case 1:
						return "Mon";
					case 2:
						return "Tue";
					case 3:
						return "Wed";
					case 4:
						return "Thu";
					case 5:
						return "Fri";
					case 6:
						return "Sat";
					case 7:
						return "Sun";
					default:
						throw DateTimeException();
				}
			} };
			switch (_localTimeZone) {
				case LocalTimeZone::EN_US:
					return monthString + "/" + dayOfMonthString + "/" + yearString + " " + hourString + ":" + minuteString + ":" + secondString + " " + WeekToString(DayOfWeek());
				case LocalTimeZone::ZH_CN:
					return yearString + "/" + monthString + "/" + dayOfMonthString + " " + hourString + ":" + minuteString + ":" + secondString + " " + WeekToString(DayOfWeek());
				default:
					throw DateTimeException();
			}
		}
	};
}

