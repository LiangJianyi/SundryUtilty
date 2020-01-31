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

int Janyee::DateTime::Year() const {
	return _tm.tm_year + 1900;
}

int Janyee::DateTime::Month() const {
	return _tm.tm_mon + 1;
}

int Janyee::DateTime::DayOfMonth() const {
	return _tm.tm_mday;
}

int Janyee::DateTime::DayOfWeek() const {
	return _tm.tm_wday + 1;
}

int Janyee::DateTime::DayOfYear() const {
	return _tm.tm_yday + 1;
}

bool Janyee::DateTime::IsDaylightSavingTime() const {
	return _tm.tm_isdst;
}

int Janyee::DateTime::Hour() const {
	return _tm.tm_hour;
}

int Janyee::DateTime::Minute() const {
	return _tm.tm_min;
}

int Janyee::DateTime::Second() const {
	return _tm.tm_sec;
}
