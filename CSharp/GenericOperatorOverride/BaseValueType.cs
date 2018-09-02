using System;
using System.Numerics;

namespace Janyee.Utilty {
	internal static class ErrorMessage {
		internal static string ValueTypeErrMsg(Type value) => $"\"value\" type is invalid cast: {value}";
		internal static string LeftTypeErrMsg(Type value) => $"\"left\" type is invalid cast: {value}";
		internal static string RightTypeErrMsg(Type value) => $"\"right\" type is invalid cast: {value}";
	}

	public class BaseValueType {
		protected object _value;
		internal BaseValueType() => this._value = null;
		internal BaseValueType(object value) {
			if (IsNumeric(value)) {
				this._value = value;
			}
			else {
				throw new InvalidCastException(ErrorMessage.ValueTypeErrMsg(value.GetType()));
			}
		}

		public static ValueType operator +(BaseValueType left, BaseValueType right) {
			if (left is Integer linteger) {
				switch (right) {
					case Integer rinteger:
						return ((int)linteger._value) + ((int)rinteger._value);
					case Double rdouble:
						return ((int)linteger._value) + ((double)rdouble._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Double ldouble) {
				switch (right) {
					case Integer rinteger:
						return ((double)ldouble._value) + ((int)rinteger._value);
					case Double rdouble:
						return ((double)ldouble._value) + ((double)rdouble._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Decimal ldecimal) {
				switch (right) {
					case Integer rinteger:
						return ((double)ldecimal._value) + ((int)rinteger._value);
					case Double rdouble:
						return ((double)ldecimal._value) + ((double)rdouble._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static bool IsInteger(BaseValueType value) {
			return (value._value is sbyte || value._value is short || value._value is int
					|| value._value is long || value._value is byte || value._value is ushort
					|| value._value is uint || value._value is ulong
					|| value._value is System.Numerics.BigInteger);
		}

		public static bool IsFloat(BaseValueType value) {
			return (value._value is float | value._value is double | value._value is decimal);
		}

		public static bool IsNumeric(BaseValueType value) {
			return (value._value is byte ||
					value._value is short ||
					value._value is int ||
					value._value is long ||
					value._value is sbyte ||
					value._value is ushort ||
					value._value is uint ||
					value._value is ulong ||
					value._value is System.Numerics.BigInteger ||
					value._value is decimal ||
					value._value is double ||
					value._value is float);
		}

		public static bool IsInteger(object value) {
			return (value is sbyte || value is short || value is int
					|| value is long || value is byte || value is ushort
					|| value is uint || value is ulong
					|| value is System.Numerics.BigInteger);
		}

		public static bool IsFloat(object value) {
			return (value is float | value is double | value is decimal);
		}

		public static bool IsNumeric(object value) {
			return (value is byte ||
					value is short ||
					value is int ||
					value is long ||
					value is sbyte ||
					value is ushort ||
					value is uint ||
					value is ulong ||
					value is System.Numerics.BigInteger ||
					value is decimal ||
					value is double ||
					value is float);
		}

	}

	public class Integer : BaseValueType {
		public Integer(object value = null) : base(value) { }

		public static int operator +(Integer left, Integer right) {
			if (left._value is int l) {
				if (right._value is int r) {
					return l + r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}
	}

	public class Double : BaseValueType {
		public Double(object value = null) : base(value) { }

		public static double operator +(Double left, Double right) {
			if (left._value is double l) {
				if (right._value is double r) {
					return l + r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}
	}

	public class Decimal : BaseValueType {
		public Decimal(object value = null) : base(value) { }

		public static decimal operator +(Decimal left, Decimal right) {
			if (left._value is decimal l) {
				if (right._value is decimal r) {
					return l + r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}
	}
}
