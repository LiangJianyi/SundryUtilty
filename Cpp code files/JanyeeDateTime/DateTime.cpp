#include "pch.h"
#include "DateTime.h"

void Janyee::DateTime::CheckErrno(errno_t err) {
	switch (err) {
		case 0:
			return;
		case EPERM:
			throw DateTimeException(L"Operation not permitted.");
		case ENOENT:
			throw DateTimeException(L"No such file or directory.");
		case ESRCH:
			throw DateTimeException(L"No such process.");
		case EINTR:
			throw DateTimeException(L"Interrupted function.");
		case EIO:
			throw DateTimeException(L"I/O error.");
		case ENXIO:
			throw DateTimeException(L"No such device or address.");
		case E2BIG:
			throw DateTimeException(L"Argument list too long.");
		case ENOEXEC:
			throw DateTimeException(L"Exec format error.");
		case EBADF:
			throw DateTimeException(L"Bad file number.");
		case ECHILD:
			throw DateTimeException(L"No spawned processes.");
		case EAGAIN:
			throw DateTimeException(L"No more processes or not enough memory or maximum nesting level reached.");
		case ENOMEM:
			throw DateTimeException(L"Not enough memory.");
		case EACCES:
			throw DateTimeException(L"Permission denied.");
		case EFAULT:
			throw DateTimeException(L"Bad address.");
		case EBUSY:
			throw DateTimeException(L"Device or resource busy.");
		case EEXIST:
			throw DateTimeException(L"File exists.");
		case EXDEV:
			throw DateTimeException(L"Cross-device link.");
		case ENODEV:
			throw DateTimeException(L"No such device.");
		case ENOTDIR:
			throw DateTimeException(L"Not a directory.");
		case EISDIR:
			throw DateTimeException(L"Is a directory.");
		case EINVAL:
			throw DateTimeException(L"Invalid argument.");
		case ENFILE:
			throw DateTimeException(L"Too many files open in system.");
		case EMFILE:
			throw DateTimeException(L"Too many open files.");
		case ENOTTY:
			throw DateTimeException(L"Inappropriate I/O control operation.");
		case EFBIG:
			throw DateTimeException(L"File too large.");
		case ENOSPC:
			throw DateTimeException(L"No space left on device.");
		case ESPIPE:
			throw DateTimeException(L"Invalid seek.");
		case EROFS:
			throw DateTimeException(L"Read-only file system.");
		case EMLINK:
			throw DateTimeException(L"Too many links.");
		case EPIPE:
			throw DateTimeException(L"Broken pipe.");
		case EDOM:
			throw DateTimeException(L"Math argument.");
		case ERANGE:
			throw DateTimeException(L"Result too large.");
		case EDEADLK:
			throw DateTimeException(L"Resource deadlock would occur.");
		case ENAMETOOLONG:
			throw DateTimeException(L"Filename too long.");
		case ENOLCK:
			throw DateTimeException(L"No locks available.");
		case ENOSYS:
			throw DateTimeException(L"Function not supported.");
		case ENOTEMPTY:
			throw DateTimeException(L"Directory not empty.");
		case EILSEQ:
			throw DateTimeException(L"Illegal byte sequence.");
		case STRUNCATE:
			throw DateTimeException(L"String was truncated.");
		default:
			throw std::exception((std::string("Unkown error. Error code: ") + std::to_string(err)).c_str());
	}
}

void Janyee::DateTime::SetYear(decltype(_year) const& year) {
	if (year < 0) {
		std::wstring s { std::wstring(L"Value of year is illegality: ") + std::to_wstring(year) };
		throw DateTimeException(s);
	}
	else {
		_year = year;
	}
}

void Janyee::DateTime::SetMonth(decltype(_month) const& month) {
	auto checkMonth = [&]()->bool {
		std::map<int, int> monthPair;
		monthPair[1] = 31;
		monthPair[2] = IsLeapYear() ? 29 : 28;
		monthPair[3] = 31;
		monthPair[4] = 30;
		monthPair[5] = 31;
		monthPair[6] = 30;
		monthPair[7] = 31;
		monthPair[8] = 31;
		monthPair[9] = 30;
		monthPair[10] = 31;
		monthPair[11] = 30;
		monthPair[12] = 31;
		return monthPair.find(month) == monthPair.end();
	};

	if (month < 0 || checkMonth()) {
		std::wstring s { std::wstring(L"Value of month is illegality: ") + std::to_wstring(month) };
		throw DateTimeException(s);
	}
	else {
		_month = month;
	}
}

void Janyee::DateTime::SetDayOfMonth(decltype(_dayOfMonth) const& dayOfMonth) {
	if (dayOfMonth < 0) {
		std::wstring s { std::wstring(L"Value of month is illegality: ") + std::to_wstring(dayOfMonth) };
		throw DateTimeException(s);
	}
	else {
		_dayOfMonth = dayOfMonth;
	}
}

/*
https://weibolu.online/2019/08/04/基础算法3%20——%20日期推测星期数/
*/
void Janyee::DateTime::SetDayOfWeek(int const& year, int const& month, int const& day) {
	int c = year / 100;
	int d = year % 100;
	int week = (c / 4) - 2 * c + (d + d / 4) + (13 * (month + 1) / 5) + day - 1;
	if (week < 0) {
		week = (week + (-week / 7 + 1) * 7) % 7;
	}
	else {
		week %= 7;
	}
	_dayOfWeek = week;
}

/*
https://blog.csdn.net/qq_34732729/article/details/103185602
*/
void Janyee::DateTime::SetDayOfYear(int const& yy, int const& mm, int const& dd) {
	int year = yy / 10;
	int month = mm / 10;
	//int day = dd / 10;
	int monthList[] = { 0,31,28,31,30,31,30,31,31,30,31,30,31 };    // 每个月的天数，从0开始        
	if (IsLeapYear(year))
		monthList[2] += 1;
	int days = 0;
	for (int i = 0; i < month; ++i) {
		days += monthList[i];
	}
	_dayOfYear = days + dd;
}

void Janyee::DateTime::SetHour(decltype(_hour) const& hour) {
	if (hour < 0 || hour>23) {
		std::wstring s { std::wstring(L"Value of hour is illegality: ") + std::to_wstring(hour) };
		throw DateTimeException(s);
	}
	else {
		_hour = hour;
	}
}

void Janyee::DateTime::SetMinute(decltype(_minute) const& minute) {
	if (minute < 0 || minute>59) {
		std::wstring s { std::wstring(L"Value of minute is illegality: ") + std::to_wstring(minute) };
		throw DateTimeException(s);
	}
	else {
		_minute = minute;
	}
}

void Janyee::DateTime::SetSecond(decltype(_second) const& second) {
	if (second < 0 || second > 59) {
		std::wstring s { std::wstring(L"Value of second is illegality: ") + std::to_wstring(second) };
		throw DateTimeException(s);
	}
	else {
		_second = second;
	}
}

Janyee::DateTime Janyee::DateTime::Now() {
	return DateTime(std::chrono::system_clock::to_time_t(std::chrono::system_clock::now()));
}

int Janyee::DateTime::GetYear() const {
	return _year;
}

int Janyee::DateTime::GetMonth() const {
	return _month;
}

int Janyee::DateTime::GetDayOfMonth() const {
	return _dayOfMonth;
}

int Janyee::DateTime::GetDayOfWeek() const {
	return _dayOfWeek;
}

int Janyee::DateTime::GetDayOfYear() const {
	return _dayOfYear;
}

bool Janyee::DateTime::IsDaylightSavingTime() const {
	return _isDaylightSavingTime;
}

int Janyee::DateTime::GetHour() const {
	return _hour;
}

int Janyee::DateTime::GetMinute() const {
	return _minute;
}

int Janyee::DateTime::GetSecond() const {
	return _second;
}

bool Janyee::DateTime::IsLeapYear() const {
	return (_year % 4 == 0 && _year % 100 != 0) || _year % 400 == 0;
}

bool Janyee::DateTime::IsLeapYear(int year) const {
	return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
}

void Janyee::DateTime::SetLocalTimeZone(LocalTimeZone const& local) {
	_localTimeZone = local;
}

Janyee::LocalTimeZone Janyee::DateTime::GetLocalTimeZone() const {
	return _localTimeZone;
}

std::string Janyee::DateTime::ToString() const {
	auto WeekToString { [](int const& week)->std::string {
		switch (week) {
			case 0:
				return "Sun.";
			case 1:
				return "Mon.";
			case 2:
				return "Tue.";
			case 3:
				return "Wed.";
			case 4:
				return "Thu.";
			case 5:
				return "Fri.";
			case 6:
				return "Sat.";
			default:
				throw DateTimeException();
		}
	} };
	const std::string yearString { std::to_string(GetYear()) };
	const std::string monthString { std::to_string(GetMonth()) };
	const std::string dayOfMonthString { std::to_string(GetDayOfMonth()) };
	const std::string yearOfWeekString { WeekToString(GetDayOfWeek()) };
	const std::string hourString { std::to_string(GetHour()) };
	const std::string minuteString { std::to_string(GetMinute()) };
	const std::string secondString { std::to_string(GetSecond()) };
	switch (_localTimeZone) {
		case LocalTimeZone::EN_US:
			return monthString + "/" + dayOfMonthString + "/" + yearString + " " + hourString + ":" + minuteString + ":" + secondString + " " + yearOfWeekString;
		case LocalTimeZone::ZH_CN:
			return yearString + "/" + monthString + "/" + dayOfMonthString + " " + hourString + ":" + minuteString + ":" + secondString + " " + yearOfWeekString;
		default:
			throw DateTimeException();
	}
}

std::string Janyee::DateTime::ToShortDate() const {
	const std::string yearString { std::to_string(GetYear()) };
	const std::string monthString { std::to_string(GetMonth()) };
	const std::string dayOfMonthString { std::to_string(GetDayOfMonth()) };
	switch (_localTimeZone) {
		case LocalTimeZone::EN_US:
			return monthString + "/" + dayOfMonthString + "/" + yearString;
		case LocalTimeZone::ZH_CN:
			return yearString + "/" + monthString + "/" + dayOfMonthString;
		default:
			throw DateTimeException();
	}
}

std::string Janyee::DateTime::ToShortTime() const {
	const std::string hourString { std::to_string(GetHour()) };
	const std::string minuteString { std::to_string(GetMinute()) };
	const std::string secondString { std::to_string(GetSecond()) };
	return hourString + ":" + minuteString + ":" + secondString;
}
