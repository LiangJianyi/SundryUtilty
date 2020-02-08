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
		std::shared_ptr<int> _year;
		std::shared_ptr<int> _month;
		std::shared_ptr<int> _dayOfMonth;
		std::shared_ptr<int> _dayOfWeek;
		std::shared_ptr<int> _dayOfYear;
		std::shared_ptr<bool> _isDaylightSavingTime;
		std::shared_ptr<int> _hour;
		std::shared_ptr<int> _minute;
		std::shared_ptr<int> _second;
		std::shared_ptr<LocalTimeZone> _localTimeZone;
		void CheckErrno(errno_t err);
		void SetYear(decltype(_year) year);
		void SetMonth(decltype(_month) month);
		void SetDayOfMonth(decltype(_dayOfMonth) dayOfMonth);
		decltype(_dayOfWeek) SetDayOfWeek(std::shared_ptr<int> year, std::shared_ptr<int> month, std::shared_ptr<int> day) const;
		decltype(_dayOfYear) SetDayOfYear(std::shared_ptr<int> yearPtr, std::shared_ptr<int> monthPtr, std::shared_ptr<int> dayPtr) const;
		void SetHour(decltype(_hour) hour);
		void SetMinute(decltype(_minute) minute);
		void SetSecond(decltype(_second) second);
	public:
		DateTime() :_now(), _tm(),
			_year(std::make_shared<int>(1)),
			_month(std::make_shared<int>(1)),
			_dayOfMonth(std::make_shared<int>(1)),
			_dayOfWeek(SetDayOfWeek(_year, _month, _dayOfMonth)),
			_dayOfYear(SetDayOfYear(_year, _month, _dayOfMonth)),
			_isDaylightSavingTime(std::make_shared<bool>(false)),
			_hour(std::make_shared<int>(0)),
			_minute(std::make_shared<int>(0)),
			_second(std::make_shared<int>(0)),
			_localTimeZone(std::make_shared<LocalTimeZone>(LocalTimeZone::ZH_CN)) {
			CheckErrno(localtime_s(&_tm, &_now));
		}
		DateTime(time_t const& time) :_now(time), _tm(),
			_year(std::make_shared<int>(_tm.tm_year + 1900)),
			_month(std::make_shared<int>(_tm.tm_mon + 1)),
			_dayOfMonth(std::make_shared<int>(_tm.tm_mday)),
			_dayOfWeek(std::make_shared<int>(_tm.tm_wday + 1)),
			_dayOfYear(std::make_shared<int>(_tm.tm_yday + 1)),
			_isDaylightSavingTime(std::make_shared<bool>(false)),
			_hour(std::make_shared<int>(_tm.tm_isdst)),
			_minute(std::make_shared<int>(_tm.tm_hour)),
			_second(std::make_shared<int>(_tm.tm_min)),
			_localTimeZone(std::make_shared<LocalTimeZone>(LocalTimeZone::ZH_CN)) {
			CheckErrno(localtime_s(&_tm, &_now));
		}
		DateTime(int year, int month, int day, int hour = 0, int minute = 0, int second = 0, bool dayLight = false, LocalTimeZone localTimeZone = LocalTimeZone::ZH_CN) :_now(), _tm(),
			_year(std::make_shared<int>(year)),
			_month(std::make_shared<int>(month)),
			_dayOfMonth(std::make_shared<int>(day)),
			_dayOfWeek(SetDayOfWeek(_year, _month, _dayOfMonth)),
			_dayOfYear(SetDayOfYear(_year, _month, _dayOfMonth)),
			_isDaylightSavingTime(std::make_shared<bool>(dayLight)),
			_hour(std::make_shared<int>(hour)),
			_minute(std::make_shared<int>(minute)),
			_second(std::make_shared<int>(second)),
			_localTimeZone(std::make_shared<LocalTimeZone>(localTimeZone)) {
			CheckErrno(localtime_s(&_tm, &_now));
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
			_localTimeZone = std::make_shared<LocalTimeZone>(local);
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
						throw std::exception();
				}
			} };
			switch (*_localTimeZone) {
				case LocalTimeZone::EN_US:
					return monthString + "/" + dayOfMonthString + "/" + yearString + " " + hourString + ":" + minuteString + ":" + secondString + " " + WeekToString(DayOfWeek());
				case LocalTimeZone::ZH_CN:
					return yearString + "/" + monthString + "/" + dayOfMonthString + " " + hourString + ":" + minuteString + ":" + secondString + " " + WeekToString(DayOfWeek());
				default:
					throw std::exception();
			}
		}
	};
}

