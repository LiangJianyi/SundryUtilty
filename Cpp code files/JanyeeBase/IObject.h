#pragma once
#include <iostream>

namespace Janyee
{
#define IObject_Equals(x, y) x.Equal(x, y)

	struct IObject
	{
		virtual std::string ToString() const = 0;
		virtual int GetHashCode() const = 0;
		template<typename This, typename Dest> bool Equal(This const& other, Dest const& dest) const {
			return dest == other;
		}
	};
}

