using System;
using System.Numerics;

namespace Janyee.Utilty {
	public class BaseValueType {
		protected object _value;
		internal BaseValueType() => this._value = null;
		internal BaseValueType(object value) {
			if (IsNumeric(value)) {
				this._value = value;
			}
			else {
				throw new InvalidCastException($"\"value\" type is invalid cast: {value.GetType()}");
			}
		}

		//public static ValueType Add(BaseValueType left,BaseValueType right) {
		//	Func<BaseValueType, BaseValueType, ValueType> calcRight = (a, b) => {
		//		switch (b) {
		//			case Integer ri:
		//				return a + ri;
		//			case Double rd:
		//				return a + rd;
		//			default:
		//				throw new InvalidCastException();
		//		}
		//	};
		//	if (left is Integer li) {
		//		return calcRight(li, right);
		//	}
		//	else if (left is Double ld) {
		//		return calcRight(ld, right);
		//	}
		//	else {
		//		throw new InvalidCastException();
		//	}
		//}

		public static ValueType operator +(BaseValueType left, BaseValueType right) {
			Func<BaseValueType, BaseValueType, ValueType> calcRight = (a, b) => {
				switch (b) {
					case Integer ri:
						return ((int)a._value) + ((int)ri._value);
					case Double rd:
						return ((int)a._value) + ((double)rd._value);
					default:
						throw new InvalidCastException();
				}
			};
			if (left is Integer li) {
				switch (right) {
					case Integer ri:
						return ((int)li._value) + ((int)ri._value);
					case Double rd:
						return ((int)li._value) + ((double)rd._value);
					default:
						throw new InvalidCastException($"\"right\" type is invalid cast: {right.GetType()}");
				}
			}
			else if (left is Double ld) {
				switch (right) {
					case Integer ri:
						return ((double)ld._value) + ((int)ri._value);
					case Double rd:
						return ((double)ld._value) + ((double)rd._value);
					default:
						throw new InvalidCastException($"\"right\" type is invalid cast: {right.GetType()}");
				}
			}
			else {
				throw new InvalidCastException($"\"left\" type is invalid cast: {left.GetType()}");
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
					throw new InvalidCastException($"\"right\" type is invalid cast: {right.GetType()}");
				}
			}
			else {
				throw new InvalidCastException($"\"left\" type is invalid cast: {left.GetType()}");
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
					throw new InvalidCastException($"\"right\" type is invalid cast: {right.GetType()}");
				}
			}
			else {
				throw new InvalidCastException($"\"left\" type is invalid cast: {left.GetType()}");
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
					throw new InvalidCastException($"\"right\" type is invalid cast: {right.GetType()}");
				}
			}
			else {
				throw new InvalidCastException($"\"left\" type is invalid cast: {left.GetType()}");
			}
		}
	}
}
