#include "pch.h"
#include "DateTime.h"

void Janyee::DateTime::CheckErrno(errno_t err) {
	switch (err) {
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

/*
	Algorithm reference: https://weibolu.online/2019/08/04/基础算法3%20——%20日期推测星期数/
*/
int Janyee::DateTime::SetDayOfWeek(std::shared_ptr<int> year, std::shared_ptr<int> month, std::shared_ptr<int> day) const {
	int c = *year / 100;
	int d = *year % 100;
	int week = (c / 4) - 2 * c + (d + d / 4) + (13 * (*month + 1) / 5) + *day - 1;
	if (week < 0) {
		week = (week + (-week / 7 + 1) * 7) % 7;
	}
	else {
		week %= 7;
	}
	return week;
}

int Janyee::DateTime::SetDayOfYear(std::shared_ptr<int> yearPtr, std::shared_ptr<int> monthPtr, std::shared_ptr<int> dayPtr) const {
	int year = *yearPtr / 10;
	int mm = *monthPtr / 10;
	int day = *dayPtr / 10;
	int month[] = { 0,31,28,31,30,31,30,31,31,30,31,30,31 };    // 每个月的天数，从0开始        
	if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)     // 闰年计算法            
		month[2] += 1;
	int days = 0;
	for (int i = 0; i < mm; ++i) {
		days += month[i];
	}
	return days + day;

}

Janyee::DateTime Janyee::DateTime::Now() {
	return DateTime(std::chrono::system_clock::to_time_t(std::chrono::system_clock::now()));
}

int Janyee::DateTime::Year() const {
	return *_year;
}

int Janyee::DateTime::Month() const {
	return *_month;
}

int Janyee::DateTime::DayOfMonth() const {
	return *_dayOfMonth;
}

int Janyee::DateTime::DayOfWeek() const {
	return *_dayOfWeek;
}

int Janyee::DateTime::DayOfYear() const {
	return *_dayOfYear;
}

bool Janyee::DateTime::IsDaylightSavingTime() const {
	return *_isDaylightSavingTime;
}

int Janyee::DateTime::Hour() const {
	return *_hour;
}

int Janyee::DateTime::Minute() const {
	return *_minute;
}

int Janyee::DateTime::Second() const {
	return *_second;
}
