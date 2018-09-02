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
			if (left is Byte lbyte) {
				switch (right) {
					case Byte rbyte:
						return ((byte)lbyte._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((byte)lbyte._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((byte)lbyte._value) + ((int)rinteger._value);
					case Long rlong:
						return ((byte)lbyte._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((byte)lbyte._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((byte)lbyte._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((byte)lbyte._value) + ((uint)ruinteger._value);
					case ULong rulong:
						return ((byte)lbyte._value) + ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((byte)lbyte._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((byte)lbyte._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((byte)lbyte._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						return ((byte)lbyte._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Short lshort) {
				switch (right) {
					case Byte rbyte:
						return ((short)lshort._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((short)lshort._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((short)lshort._value) + ((int)rinteger._value);
					case Long rlong:
						return ((short)lshort._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((short)lshort._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((short)lshort._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((short)lshort._value) + ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'short' and 'ulong'");
					case BigInteger rbiginteger:
						return ((short)lshort._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((short)lshort._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((short)lshort._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						return ((short)lshort._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Integer linteger) {
				switch (right) {
					case Byte rbyte:
						return ((int)linteger._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((int)linteger._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((int)linteger._value) + ((int)rinteger._value);
					case Long rlong:
						return ((int)linteger._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((int)linteger._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((int)linteger._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((int)linteger._value) + ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'int' and 'ulong'");
					case BigInteger rbiginteger:
						return ((int)linteger._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((int)linteger._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((int)linteger._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						return ((int)linteger._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Long llong) {
				switch (right) {
					case Byte rbyte:
						return ((long)llong._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((long)llong._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((long)llong._value) + ((int)rinteger._value);
					case Long rlong:
						return ((long)llong._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((long)llong._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)llong._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((long)llong._value) + ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'long' and 'ulong'");
					case BigInteger rbiginteger:
						return ((long)llong._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((long)llong._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((long)llong._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						return ((long)llong._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is SByte lsbyte) {
				switch (right) {
					case Byte rbyte:
						return ((sbyte)lsbyte._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((sbyte)lsbyte._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((sbyte)lsbyte._value) + ((int)rinteger._value);
					case Long rlong:
						return ((sbyte)lsbyte._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((sbyte)lsbyte._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)lsbyte._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((sbyte)lsbyte._value) + ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'sbyte' and 'ulong'");
					case BigInteger rbiginteger:
						return ((sbyte)lsbyte._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((sbyte)lsbyte._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((sbyte)lsbyte._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						return ((sbyte)lsbyte._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UShort lushort) {
				switch (right) {
					case Byte rbyte:
						return ((ushort)lushort._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((ushort)lushort._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((ushort)lushort._value) + ((int)rinteger._value);
					case Long rlong:
						return ((ushort)lushort._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((ushort)lushort._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((ushort)lushort._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ushort)lushort._value) + ((uint)ruinteger._value);
					case ULong rulong:
						return ((ushort)lushort._value) + ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ushort)lushort._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ushort)lushort._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((ushort)lushort._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ushort)lushort._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UInteger luinteger) {
				switch (right) {
					case Byte rbyte:
						return ((uint)luinteger._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((uint)luinteger._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((uint)luinteger._value) + ((int)rinteger._value);
					case Long rlong:
						return ((uint)luinteger._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((uint)luinteger._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((uint)luinteger._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((uint)luinteger._value) + ((uint)ruinteger._value);
					case ULong rulong:
						return ((uint)luinteger._value) + ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((uint)luinteger._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((uint)luinteger._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((uint)luinteger._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						return ((uint)luinteger._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is ULong lulong) {
				switch (right) {
					case Byte rbyte:
						return ((ulong)lulong._value) + ((byte)rbyte._value);
					case Short rshort:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'ulong' and 'short'");
					case Integer rinteger:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'ulong' and 'int'");
					case Long rlong:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'ulong' and 'long'");
					case SByte rsbyte:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'ulong' and 'sbyte'");
					case UShort rushort:
						return ((ulong)lulong._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ulong)lulong._value) + ((uint)ruinteger._value);
					case ULong rulong:
						return ((ulong)lulong._value) + ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ulong)lulong._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ulong)lulong._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((ulong)lulong._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ulong)lulong._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is BigInteger lbiginteger) {
				switch (right) {
					case Byte rbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((int)rinteger._value);
					case Long rlong:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((uint)ruinteger._value);
					case ULong rulong:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) + ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'BigInteger' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'BigInteger' and 'double'");
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'BigInteger' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Float lfloat) {
				switch (right) {
					case Byte rbyte:
						return ((float)lfloat._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((float)lfloat._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((float)lfloat._value) + ((int)rinteger._value);
					case Long rlong:
						return ((float)lfloat._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((float)lfloat._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((float)lfloat._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((float)lfloat._value) + ((uint)ruinteger._value);
					case ULong rulong:
						return ((float)lfloat._value) + ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'float' and 'BigInteger'");
					case Float rfloat:
						return ((float)lfloat._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((float)lfloat._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'float' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Double ldouble) {
				switch (right) {
					case Byte rbyte:
						return ((double)ldouble._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((double)ldouble._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((double)ldouble._value) + ((int)rinteger._value);
					case Long rlong:
						return ((double)ldouble._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((double)ldouble._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((double)ldouble._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((double)ldouble._value) + ((uint)ruinteger._value);
					case ULong rulong:
						return ((double)ldouble._value) + ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'double' and 'BigInteger'");
					case Float rfloat:
						return ((double)ldouble._value) + ((float)rfloat._value);
					case Double rdouble:
						return ((double)ldouble._value) + ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'double' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Decimal ldecimal) {
				switch (right) {
					case Byte rbyte:
						return ((decimal)ldecimal._value) + ((byte)rbyte._value);
					case Short rshort:
						return ((decimal)ldecimal._value) + ((short)rshort._value);
					case Integer rinteger:
						return ((decimal)ldecimal._value) + ((int)rinteger._value);
					case Long rlong:
						return ((decimal)ldecimal._value) + ((long)rlong._value);
					case SByte rsbyte:
						return ((decimal)ldecimal._value) + ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((decimal)ldecimal._value) + ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((decimal)ldecimal._value) + ((uint)ruinteger._value);
					case ULong rulong:
						return ((decimal)ldecimal._value) + ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'decimal' and 'BigInteger'");
					case Float rfloat:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'decimal' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '+' cannot be applied to operands of type 'decimal' and 'double'");
					case Decimal rdecimal:
						return ((decimal)ldecimal._value) + ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ValueType operator -(BaseValueType left, BaseValueType right) {
			if (left is Byte lbyte) {
				switch (right) {
					case Byte rbyte:
						return ((byte)lbyte._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((byte)lbyte._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((byte)lbyte._value) - ((int)rinteger._value);
					case Long rlong:
						return ((byte)lbyte._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((byte)lbyte._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((byte)lbyte._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((byte)lbyte._value) - ((uint)ruinteger._value);
					case ULong rulong:
						return ((byte)lbyte._value) - ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((byte)lbyte._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((byte)lbyte._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((byte)lbyte._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						return ((byte)lbyte._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Short lshort) {
				switch (right) {
					case Byte rbyte:
						return ((short)lshort._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((short)lshort._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((short)lshort._value) - ((int)rinteger._value);
					case Long rlong:
						return ((short)lshort._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((short)lshort._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((short)lshort._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((short)lshort._value) - ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'short' and 'ulong'");
					case BigInteger rbiginteger:
						return ((short)lshort._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((short)lshort._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((short)lshort._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						return ((short)lshort._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Integer linteger) {
				switch (right) {
					case Byte rbyte:
						return ((int)linteger._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((int)linteger._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((int)linteger._value) - ((int)rinteger._value);
					case Long rlong:
						return ((int)linteger._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((int)linteger._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((int)linteger._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((int)linteger._value) - ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'int' and 'ulong'");
					case BigInteger rbiginteger:
						return ((int)linteger._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((int)linteger._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((int)linteger._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						return ((int)linteger._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Long llong) {
				switch (right) {
					case Byte rbyte:
						return ((long)llong._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((long)llong._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((long)llong._value) - ((int)rinteger._value);
					case Long rlong:
						return ((long)llong._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((long)llong._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)llong._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((long)llong._value) - ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'long' and 'ulong'");
					case BigInteger rbiginteger:
						return ((long)llong._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((long)llong._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((long)llong._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						return ((long)llong._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is SByte lsbyte) {
				switch (right) {
					case Byte rbyte:
						return ((sbyte)lsbyte._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((sbyte)lsbyte._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((sbyte)lsbyte._value) - ((int)rinteger._value);
					case Long rlong:
						return ((sbyte)lsbyte._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((sbyte)lsbyte._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)lsbyte._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((sbyte)lsbyte._value) - ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'sbyte' and 'ulong'");
					case BigInteger rbiginteger:
						return ((sbyte)lsbyte._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((sbyte)lsbyte._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((sbyte)lsbyte._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						return ((sbyte)lsbyte._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UShort lushort) {
				switch (right) {
					case Byte rbyte:
						return ((ushort)lushort._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((ushort)lushort._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((ushort)lushort._value) - ((int)rinteger._value);
					case Long rlong:
						return ((ushort)lushort._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((ushort)lushort._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((ushort)lushort._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ushort)lushort._value) - ((uint)ruinteger._value);
					case ULong rulong:
						return ((ushort)lushort._value) - ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ushort)lushort._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ushort)lushort._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((ushort)lushort._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ushort)lushort._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UInteger luinteger) {
				switch (right) {
					case Byte rbyte:
						return ((uint)luinteger._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((uint)luinteger._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((uint)luinteger._value) - ((int)rinteger._value);
					case Long rlong:
						return ((uint)luinteger._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((uint)luinteger._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((uint)luinteger._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((uint)luinteger._value) - ((uint)ruinteger._value);
					case ULong rulong:
						return ((uint)luinteger._value) - ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((uint)luinteger._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((uint)luinteger._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((uint)luinteger._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						return ((uint)luinteger._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is ULong lulong) {
				switch (right) {
					case Byte rbyte:
						return ((ulong)lulong._value) - ((byte)rbyte._value);
					case Short rshort:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'ulong' and 'short'");
					case Integer rinteger:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'ulong' and 'int'");
					case Long rlong:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'ulong' and 'long'");
					case SByte rsbyte:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'ulong' and 'sbyte'");
					case UShort rushort:
						return ((ulong)lulong._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ulong)lulong._value) - ((uint)ruinteger._value);
					case ULong rulong:
						return ((ulong)lulong._value) - ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ulong)lulong._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ulong)lulong._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((ulong)lulong._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ulong)lulong._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is BigInteger lbiginteger) {
				switch (right) {
					case Byte rbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((int)rinteger._value);
					case Long rlong:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((uint)ruinteger._value);
					case ULong rulong:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) - ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'BigInteger' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'BigInteger' and 'double'");
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'BigInteger' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Float lfloat) {
				switch (right) {
					case Byte rbyte:
						return ((float)lfloat._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((float)lfloat._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((float)lfloat._value) - ((int)rinteger._value);
					case Long rlong:
						return ((float)lfloat._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((float)lfloat._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((float)lfloat._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((float)lfloat._value) - ((uint)ruinteger._value);
					case ULong rulong:
						return ((float)lfloat._value) - ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'float' and 'BigInteger'");
					case Float rfloat:
						return ((float)lfloat._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((float)lfloat._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'float' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Double ldouble) {
				switch (right) {
					case Byte rbyte:
						return ((double)ldouble._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((double)ldouble._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((double)ldouble._value) - ((int)rinteger._value);
					case Long rlong:
						return ((double)ldouble._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((double)ldouble._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((double)ldouble._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((double)ldouble._value) - ((uint)ruinteger._value);
					case ULong rulong:
						return ((double)ldouble._value) - ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'double' and 'BigInteger'");
					case Float rfloat:
						return ((double)ldouble._value) - ((float)rfloat._value);
					case Double rdouble:
						return ((double)ldouble._value) - ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'double' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Decimal ldecimal) {
				switch (right) {
					case Byte rbyte:
						return ((decimal)ldecimal._value) - ((byte)rbyte._value);
					case Short rshort:
						return ((decimal)ldecimal._value) - ((short)rshort._value);
					case Integer rinteger:
						return ((decimal)ldecimal._value) - ((int)rinteger._value);
					case Long rlong:
						return ((decimal)ldecimal._value) - ((long)rlong._value);
					case SByte rsbyte:
						return ((decimal)ldecimal._value) - ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((decimal)ldecimal._value) - ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((decimal)ldecimal._value) - ((uint)ruinteger._value);
					case ULong rulong:
						return ((decimal)ldecimal._value) - ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'decimal' and 'BigInteger'");
					case Float rfloat:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'decimal' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '-' cannot be applied to operands of type 'decimal' and 'double'");
					case Decimal rdecimal:
						return ((decimal)ldecimal._value) - ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ValueType operator *(BaseValueType left, BaseValueType right) {
			if (left is Byte lbyte) {
				switch (right) {
					case Byte rbyte:
						return ((byte)lbyte._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((byte)lbyte._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((byte)lbyte._value) * ((int)rinteger._value);
					case Long rlong:
						return ((byte)lbyte._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((byte)lbyte._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((byte)lbyte._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((byte)lbyte._value) * ((uint)ruinteger._value);
					case ULong rulong:
						return ((byte)lbyte._value) * ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((byte)lbyte._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((byte)lbyte._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((byte)lbyte._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						return ((byte)lbyte._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Short lshort) {
				switch (right) {
					case Byte rbyte:
						return ((short)lshort._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((short)lshort._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((short)lshort._value) * ((int)rinteger._value);
					case Long rlong:
						return ((short)lshort._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((short)lshort._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((short)lshort._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((short)lshort._value) * ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'short' and 'ulong'");
					case BigInteger rbiginteger:
						return ((short)lshort._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((short)lshort._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((short)lshort._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						return ((short)lshort._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Integer linteger) {
				switch (right) {
					case Byte rbyte:
						return ((int)linteger._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((int)linteger._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((int)linteger._value) * ((int)rinteger._value);
					case Long rlong:
						return ((int)linteger._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((int)linteger._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((int)linteger._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((int)linteger._value) * ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'int' and 'ulong'");
					case BigInteger rbiginteger:
						return ((int)linteger._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((int)linteger._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((int)linteger._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						return ((int)linteger._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Long llong) {
				switch (right) {
					case Byte rbyte:
						return ((long)llong._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((long)llong._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((long)llong._value) * ((int)rinteger._value);
					case Long rlong:
						return ((long)llong._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((long)llong._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)llong._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((long)llong._value) * ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'long' and 'ulong'");
					case BigInteger rbiginteger:
						return ((long)llong._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((long)llong._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((long)llong._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						return ((long)llong._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is SByte lsbyte) {
				switch (right) {
					case Byte rbyte:
						return ((sbyte)lsbyte._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((sbyte)lsbyte._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((sbyte)lsbyte._value) * ((int)rinteger._value);
					case Long rlong:
						return ((sbyte)lsbyte._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((sbyte)lsbyte._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)lsbyte._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((sbyte)lsbyte._value) * ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'sbyte' and 'ulong'");
					case BigInteger rbiginteger:
						return ((sbyte)lsbyte._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((sbyte)lsbyte._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((sbyte)lsbyte._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						return ((sbyte)lsbyte._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UShort lushort) {
				switch (right) {
					case Byte rbyte:
						return ((ushort)lushort._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((ushort)lushort._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((ushort)lushort._value) * ((int)rinteger._value);
					case Long rlong:
						return ((ushort)lushort._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((ushort)lushort._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((ushort)lushort._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ushort)lushort._value) * ((uint)ruinteger._value);
					case ULong rulong:
						return ((ushort)lushort._value) * ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ushort)lushort._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ushort)lushort._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((ushort)lushort._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ushort)lushort._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UInteger luinteger) {
				switch (right) {
					case Byte rbyte:
						return ((uint)luinteger._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((uint)luinteger._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((uint)luinteger._value) * ((int)rinteger._value);
					case Long rlong:
						return ((uint)luinteger._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((uint)luinteger._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((uint)luinteger._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((uint)luinteger._value) * ((uint)ruinteger._value);
					case ULong rulong:
						return ((uint)luinteger._value) * ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((uint)luinteger._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((uint)luinteger._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((uint)luinteger._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						return ((uint)luinteger._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is ULong lulong) {
				switch (right) {
					case Byte rbyte:
						return ((ulong)lulong._value) * ((byte)rbyte._value);
					case Short rshort:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'ulong' and 'short'");
					case Integer rinteger:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'ulong' and 'int'");
					case Long rlong:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'ulong' and 'long'");
					case SByte rsbyte:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'ulong' and 'sbyte'");
					case UShort rushort:
						return ((ulong)lulong._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ulong)lulong._value) * ((uint)ruinteger._value);
					case ULong rulong:
						return ((ulong)lulong._value) * ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ulong)lulong._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ulong)lulong._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((ulong)lulong._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ulong)lulong._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is BigInteger lbiginteger) {
				switch (right) {
					case Byte rbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((int)rinteger._value);
					case Long rlong:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((uint)ruinteger._value);
					case ULong rulong:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) * ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'BigInteger' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'BigInteger' and 'double'");
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'BigInteger' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Float lfloat) {
				switch (right) {
					case Byte rbyte:
						return ((float)lfloat._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((float)lfloat._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((float)lfloat._value) * ((int)rinteger._value);
					case Long rlong:
						return ((float)lfloat._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((float)lfloat._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((float)lfloat._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((float)lfloat._value) * ((uint)ruinteger._value);
					case ULong rulong:
						return ((float)lfloat._value) * ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'float' and 'BigInteger'");
					case Float rfloat:
						return ((float)lfloat._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((float)lfloat._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'float' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Double ldouble) {
				switch (right) {
					case Byte rbyte:
						return ((double)ldouble._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((double)ldouble._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((double)ldouble._value) * ((int)rinteger._value);
					case Long rlong:
						return ((double)ldouble._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((double)ldouble._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((double)ldouble._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((double)ldouble._value) * ((uint)ruinteger._value);
					case ULong rulong:
						return ((double)ldouble._value) * ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'double' and 'BigInteger'");
					case Float rfloat:
						return ((double)ldouble._value) * ((float)rfloat._value);
					case Double rdouble:
						return ((double)ldouble._value) * ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'double' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Decimal ldecimal) {
				switch (right) {
					case Byte rbyte:
						return ((decimal)ldecimal._value) * ((byte)rbyte._value);
					case Short rshort:
						return ((decimal)ldecimal._value) * ((short)rshort._value);
					case Integer rinteger:
						return ((decimal)ldecimal._value) * ((int)rinteger._value);
					case Long rlong:
						return ((decimal)ldecimal._value) * ((long)rlong._value);
					case SByte rsbyte:
						return ((decimal)ldecimal._value) * ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((decimal)ldecimal._value) * ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((decimal)ldecimal._value) * ((uint)ruinteger._value);
					case ULong rulong:
						return ((decimal)ldecimal._value) * ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'decimal' and 'BigInteger'");
					case Float rfloat:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'decimal' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '*' cannot be applied to operands of type 'decimal' and 'double'");
					case Decimal rdecimal:
						return ((decimal)ldecimal._value) * ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ValueType operator /(BaseValueType left, BaseValueType right) {
			if (left is Byte lbyte) {
				switch (right) {
					case Byte rbyte:
						return ((byte)lbyte._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((byte)lbyte._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((byte)lbyte._value) / ((int)rinteger._value);
					case Long rlong:
						return ((byte)lbyte._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((byte)lbyte._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((byte)lbyte._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((byte)lbyte._value) / ((uint)ruinteger._value);
					case ULong rulong:
						return ((byte)lbyte._value) / ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((byte)lbyte._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((byte)lbyte._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((byte)lbyte._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						return ((byte)lbyte._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Short lshort) {
				switch (right) {
					case Byte rbyte:
						return ((short)lshort._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((short)lshort._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((short)lshort._value) / ((int)rinteger._value);
					case Long rlong:
						return ((short)lshort._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((short)lshort._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((short)lshort._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((short)lshort._value) / ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'short' and 'ulong'");
					case BigInteger rbiginteger:
						return ((short)lshort._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((short)lshort._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((short)lshort._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						return ((short)lshort._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Integer linteger) {
				switch (right) {
					case Byte rbyte:
						return ((int)linteger._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((int)linteger._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((int)linteger._value) / ((int)rinteger._value);
					case Long rlong:
						return ((int)linteger._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((int)linteger._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((int)linteger._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((int)linteger._value) / ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'int' and 'ulong'");
					case BigInteger rbiginteger:
						return ((int)linteger._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((int)linteger._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((int)linteger._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						return ((int)linteger._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Long llong) {
				switch (right) {
					case Byte rbyte:
						return ((long)llong._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((long)llong._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((long)llong._value) / ((int)rinteger._value);
					case Long rlong:
						return ((long)llong._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((long)llong._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)llong._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((long)llong._value) / ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'long' and 'ulong'");
					case BigInteger rbiginteger:
						return ((long)llong._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((long)llong._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((long)llong._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						return ((long)llong._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is SByte lsbyte) {
				switch (right) {
					case Byte rbyte:
						return ((sbyte)lsbyte._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((sbyte)lsbyte._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((sbyte)lsbyte._value) / ((int)rinteger._value);
					case Long rlong:
						return ((sbyte)lsbyte._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((sbyte)lsbyte._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)lsbyte._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((sbyte)lsbyte._value) / ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'sbyte' and 'ulong'");
					case BigInteger rbiginteger:
						return ((sbyte)lsbyte._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((sbyte)lsbyte._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((sbyte)lsbyte._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						return ((sbyte)lsbyte._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UShort lushort) {
				switch (right) {
					case Byte rbyte:
						return ((ushort)lushort._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((ushort)lushort._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((ushort)lushort._value) / ((int)rinteger._value);
					case Long rlong:
						return ((ushort)lushort._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((ushort)lushort._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((ushort)lushort._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ushort)lushort._value) / ((uint)ruinteger._value);
					case ULong rulong:
						return ((ushort)lushort._value) / ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ushort)lushort._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ushort)lushort._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((ushort)lushort._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ushort)lushort._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UInteger luinteger) {
				switch (right) {
					case Byte rbyte:
						return ((uint)luinteger._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((uint)luinteger._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((uint)luinteger._value) / ((int)rinteger._value);
					case Long rlong:
						return ((uint)luinteger._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((uint)luinteger._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((uint)luinteger._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((uint)luinteger._value) / ((uint)ruinteger._value);
					case ULong rulong:
						return ((uint)luinteger._value) / ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((uint)luinteger._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((uint)luinteger._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((uint)luinteger._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						return ((uint)luinteger._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is ULong lulong) {
				switch (right) {
					case Byte rbyte:
						return ((ulong)lulong._value) / ((byte)rbyte._value);
					case Short rshort:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'ulong' and 'short'");
					case Integer rinteger:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'ulong' and 'int'");
					case Long rlong:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'ulong' and 'long'");
					case SByte rsbyte:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'ulong' and 'sbyte'");
					case UShort rushort:
						return ((ulong)lulong._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ulong)lulong._value) / ((uint)ruinteger._value);
					case ULong rulong:
						return ((ulong)lulong._value) / ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ulong)lulong._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ulong)lulong._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((ulong)lulong._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ulong)lulong._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is BigInteger lbiginteger) {
				switch (right) {
					case Byte rbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((int)rinteger._value);
					case Long rlong:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((uint)ruinteger._value);
					case ULong rulong:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) / ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'BigInteger' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'BigInteger' and 'double'");
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'BigInteger' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Float lfloat) {
				switch (right) {
					case Byte rbyte:
						return ((float)lfloat._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((float)lfloat._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((float)lfloat._value) / ((int)rinteger._value);
					case Long rlong:
						return ((float)lfloat._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((float)lfloat._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((float)lfloat._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((float)lfloat._value) / ((uint)ruinteger._value);
					case ULong rulong:
						return ((float)lfloat._value) / ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'float' and 'BigInteger'");
					case Float rfloat:
						return ((float)lfloat._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((float)lfloat._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'float' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Double ldouble) {
				switch (right) {
					case Byte rbyte:
						return ((double)ldouble._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((double)ldouble._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((double)ldouble._value) / ((int)rinteger._value);
					case Long rlong:
						return ((double)ldouble._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((double)ldouble._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((double)ldouble._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((double)ldouble._value) / ((uint)ruinteger._value);
					case ULong rulong:
						return ((double)ldouble._value) / ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'double' and 'BigInteger'");
					case Float rfloat:
						return ((double)ldouble._value) / ((float)rfloat._value);
					case Double rdouble:
						return ((double)ldouble._value) / ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'double' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Decimal ldecimal) {
				switch (right) {
					case Byte rbyte:
						return ((decimal)ldecimal._value) / ((byte)rbyte._value);
					case Short rshort:
						return ((decimal)ldecimal._value) / ((short)rshort._value);
					case Integer rinteger:
						return ((decimal)ldecimal._value) / ((int)rinteger._value);
					case Long rlong:
						return ((decimal)ldecimal._value) / ((long)rlong._value);
					case SByte rsbyte:
						return ((decimal)ldecimal._value) / ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((decimal)ldecimal._value) / ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((decimal)ldecimal._value) / ((uint)ruinteger._value);
					case ULong rulong:
						return ((decimal)ldecimal._value) / ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'decimal' and 'BigInteger'");
					case Float rfloat:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'decimal' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '/' cannot be applied to operands of type 'decimal' and 'double'");
					case Decimal rdecimal:
						return ((decimal)ldecimal._value) / ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ValueType operator %(BaseValueType left, BaseValueType right) {
			if (left is Byte lbyte) {
				switch (right) {
					case Byte rbyte:
						return ((byte)lbyte._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((byte)lbyte._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((byte)lbyte._value) % ((int)rinteger._value);
					case Long rlong:
						return ((byte)lbyte._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((byte)lbyte._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((byte)lbyte._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((byte)lbyte._value) % ((uint)ruinteger._value);
					case ULong rulong:
						return ((byte)lbyte._value) % ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((byte)lbyte._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((byte)lbyte._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((byte)lbyte._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						return ((byte)lbyte._value) % ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Short lshort) {
				switch (right) {
					case Byte rbyte:
						return ((short)lshort._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((short)lshort._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((short)lshort._value) % ((int)rinteger._value);
					case Long rlong:
						return ((short)lshort._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((short)lshort._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((short)lshort._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((short)lshort._value) % ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'short' and 'ulong'");
					case BigInteger rbiginteger:
						return ((short)lshort._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((short)lshort._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((short)lshort._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						return ((short)lshort._value) % ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Integer linteger) {
				switch (right) {
					case Byte rbyte:
						return ((int)linteger._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((int)linteger._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((int)linteger._value) % ((int)rinteger._value);
					case Long rlong:
						return ((int)linteger._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((int)linteger._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((int)linteger._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((int)linteger._value) % ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'int' and 'ulong'");
					case BigInteger rbiginteger:
						return ((int)linteger._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((int)linteger._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((int)linteger._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						return ((int)linteger._value) % ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Long llong) {
				switch (right) {
					case Byte rbyte:
						return ((long)llong._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((long)llong._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((long)llong._value) % ((int)rinteger._value);
					case Long rlong:
						return ((long)llong._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((long)llong._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)llong._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((long)llong._value) % ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'long' and 'ulong'");
					case BigInteger rbiginteger:
						return ((long)llong._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((long)llong._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((long)llong._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						return ((long)llong._value) % ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is SByte lsbyte) {
				switch (right) {
					case Byte rbyte:
						return ((sbyte)lsbyte._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((sbyte)lsbyte._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((sbyte)lsbyte._value) % ((int)rinteger._value);
					case Long rlong:
						return ((sbyte)lsbyte._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((sbyte)lsbyte._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((long)lsbyte._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((sbyte)lsbyte._value) % ((uint)ruinteger._value);
					case ULong rulong:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'sbyte' and 'ulong'");
					case BigInteger rbiginteger:
						return ((sbyte)lsbyte._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((sbyte)lsbyte._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((sbyte)lsbyte._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						return ((sbyte)lsbyte._value) % ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UShort lushort) {
				switch (right) {
					case Byte rbyte:
						return ((ushort)lushort._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((ushort)lushort._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((ushort)lushort._value) % ((int)rinteger._value);
					case Long rlong:
						return ((ushort)lushort._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((ushort)lushort._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((ushort)lushort._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ushort)lushort._value) % ((uint)ruinteger._value);
					case ULong rulong:
						return ((ushort)lushort._value) % ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ushort)lushort._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ushort)lushort._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((ushort)lushort._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ushort)lushort._value) % ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is UInteger luinteger) {
				switch (right) {
					case Byte rbyte:
						return ((uint)luinteger._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((uint)luinteger._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((uint)luinteger._value) % ((int)rinteger._value);
					case Long rlong:
						return ((uint)luinteger._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((uint)luinteger._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((uint)luinteger._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((uint)luinteger._value) % ((uint)ruinteger._value);
					case ULong rulong:
						return ((uint)luinteger._value) % ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((uint)luinteger._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((uint)luinteger._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((uint)luinteger._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						return ((uint)luinteger._value) % ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is ULong lulong) {
				switch (right) {
					case Byte rbyte:
						return ((ulong)lulong._value) % ((byte)rbyte._value);
					case Short rshort:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'ulong' and 'short'");
					case Integer rinteger:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'ulong' and 'int'");
					case Long rlong:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'ulong' and 'long'");
					case SByte rsbyte:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'ulong' and 'sbyte'");
					case UShort rushort:
						return ((ulong)lulong._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((ulong)lulong._value) % ((uint)ruinteger._value);
					case ULong rulong:
						return ((ulong)lulong._value) % ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((ulong)lulong._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						return ((ulong)lulong._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((ulong)lulong._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						return ((ulong)lulong._value) % ((decimal)rdecimal._value);
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is BigInteger lbiginteger) {
				switch (right) {
					case Byte rbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((int)rinteger._value);
					case Long rlong:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((uint)ruinteger._value);
					case ULong rulong:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((ulong)rulong._value);
					case BigInteger rbiginteger:
						return ((System.Numerics.BigInteger)lbiginteger._value) % ((System.Numerics.BigInteger)rbiginteger._value);
					case Float rfloat:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'BigInteger' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'BigInteger' and 'double'");
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'BigInteger' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Float lfloat) {
				switch (right) {
					case Byte rbyte:
						return ((float)lfloat._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((float)lfloat._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((float)lfloat._value) % ((int)rinteger._value);
					case Long rlong:
						return ((float)lfloat._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((float)lfloat._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((float)lfloat._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((float)lfloat._value) % ((uint)ruinteger._value);
					case ULong rulong:
						return ((float)lfloat._value) % ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'float' and 'BigInteger'");
					case Float rfloat:
						return ((float)lfloat._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((float)lfloat._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'float' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Double ldouble) {
				switch (right) {
					case Byte rbyte:
						return ((double)ldouble._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((double)ldouble._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((double)ldouble._value) % ((int)rinteger._value);
					case Long rlong:
						return ((double)ldouble._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((double)ldouble._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((double)ldouble._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((double)ldouble._value) % ((uint)ruinteger._value);
					case ULong rulong:
						return ((double)ldouble._value) % ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'double' and 'BigInteger'");
					case Float rfloat:
						return ((double)ldouble._value) % ((float)rfloat._value);
					case Double rdouble:
						return ((double)ldouble._value) % ((double)rdouble._value);
					case Decimal rdecimal:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'double' and 'decimal'");
					default:
						throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else if (left is Decimal ldecimal) {
				switch (right) {
					case Byte rbyte:
						return ((decimal)ldecimal._value) % ((byte)rbyte._value);
					case Short rshort:
						return ((decimal)ldecimal._value) % ((short)rshort._value);
					case Integer rinteger:
						return ((decimal)ldecimal._value) % ((int)rinteger._value);
					case Long rlong:
						return ((decimal)ldecimal._value) % ((long)rlong._value);
					case SByte rsbyte:
						return ((decimal)ldecimal._value) % ((sbyte)rsbyte._value);
					case UShort rushort:
						return ((decimal)ldecimal._value) % ((ushort)rushort._value);
					case UInteger ruinteger:
						return ((decimal)ldecimal._value) % ((uint)ruinteger._value);
					case ULong rulong:
						return ((decimal)ldecimal._value) % ((ulong)rulong._value);
					case BigInteger rbiginteger:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'decimal' and 'BigInteger'");
					case Float rfloat:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'decimal' and 'float'");
					case Double rdouble:
						throw new InvalidOperationException("Operator '%' cannot be applied to operands of type 'decimal' and 'double'");
					case Decimal rdecimal:
						return ((decimal)ldecimal._value) % ((decimal)rdecimal._value);
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

	public class Short : BaseValueType {
		public Short(object value = null) : base(value) { }

		#region binary operators overloaded

		public static short operator +(Short left, Short right) {
			if (left._value is short l) {
				if (right._value is short r) {
					return (short)(l + r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static short operator -(Short left, Short right) {
			if (left._value is short l) {
				if (right._value is short r) {
					return (short)(l - r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static short operator *(Short left, Short right) {
			if (left._value is short l) {
				if (right._value is short r) {
					return (short)(l * r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static short operator /(Short left, Short right) {
			if (left._value is short l) {
				if (right._value is short r) {
					return (short)(l / r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static short operator %(Short left, Short right) {
			if (left._value is short l) {
				if (right._value is short r) {
					return (short)(l % r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class Byte : BaseValueType {
		public Byte(object value = null) : base(value) { }

		#region binary operators overloaded

		public static byte operator +(Byte left, Byte right) {
			if (left._value is byte l) {
				if (right._value is byte r) {
					return (byte)(l + r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static byte operator -(Byte left, Byte right) {
			if (left._value is byte l) {
				if (right._value is byte r) {
					return (byte)(l - r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static byte operator *(Byte left, Byte right) {
			if (left._value is byte l) {
				if (right._value is byte r) {
					return (byte)(l * r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static byte operator /(Byte left, Byte right) {
			if (left._value is byte l) {
				if (right._value is byte r) {
					return (byte)(l / r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static byte operator %(Byte left, Byte right) {
			if (left._value is byte l) {
				if (right._value is byte r) {
					return (byte)(l % r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class Integer : BaseValueType {
		public Integer(object value = null) : base(value) { }

		/******************************** unary operators overloaded ********************************/


		#region binary operators overloaded

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

		public static int operator -(Integer left, Integer right) {
			if (left._value is int l) {
				if (right._value is int r) {
					return l - r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static int operator *(Integer left, Integer right) {
			if (left._value is int l) {
				if (right._value is int r) {
					return l * r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static int operator /(Integer left, Integer right) {
			if (left._value is int l) {
				if (right._value is int r) {
					return l / r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static int operator %(Integer left, Integer right) {
			if (left._value is int l) {
				if (right._value is int r) {
					return l % r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class Long : BaseValueType {
		public Long(object value = null) : base(value) { }

		#region binary operators overloaded

		public static long operator +(Long left, Long right) {
			if (left._value is long l) {
				if (right._value is long r) {
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

		public static long operator -(Long left, Long right) {
			if (left._value is long l) {
				if (right._value is long r) {
					return l - r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static long operator *(Long left, Long right) {
			if (left._value is long l) {
				if (right._value is long r) {
					return l * r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static long operator /(Long left, Long right) {
			if (left._value is long l) {
				if (right._value is long r) {
					return l / r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static long operator %(Long left, Long right) {
			if (left._value is long l) {
				if (right._value is long r) {
					return l % r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class BigInteger : BaseValueType {
		public BigInteger(object value = null) : base(value) { }

		#region binary operators overloaded

		public static System.Numerics.BigInteger operator +(BigInteger left, BigInteger right) {
			if (left._value is System.Numerics.BigInteger l) {
				if (right._value is System.Numerics.BigInteger r) {
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

		public static System.Numerics.BigInteger operator -(BigInteger left, BigInteger right) {
			if (left._value is System.Numerics.BigInteger l) {
				if (right._value is System.Numerics.BigInteger r) {
					return l - r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static System.Numerics.BigInteger operator *(BigInteger left, BigInteger right) {
			if (left._value is System.Numerics.BigInteger l) {
				if (right._value is System.Numerics.BigInteger r) {
					return l * r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static System.Numerics.BigInteger operator /(BigInteger left, BigInteger right) {
			if (left._value is System.Numerics.BigInteger l) {
				if (right._value is System.Numerics.BigInteger r) {
					return l / r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static System.Numerics.BigInteger operator %(BigInteger left, BigInteger right) {
			if (left._value is System.Numerics.BigInteger l) {
				if (right._value is System.Numerics.BigInteger r) {
					return l % r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class SByte : BaseValueType {
		public SByte(object value = null) : base(value) { }

		#region binary operators overloaded

		public static sbyte operator +(SByte left, SByte right) {
			if (left._value is sbyte l) {
				if (right._value is sbyte r) {
					return (sbyte)(l + r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static sbyte operator -(SByte left, SByte right) {
			if (left._value is sbyte l) {
				if (right._value is sbyte r) {
					return (sbyte)(l - r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static sbyte operator *(SByte left, SByte right) {
			if (left._value is sbyte l) {
				if (right._value is sbyte r) {
					return (sbyte)(l * r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static sbyte operator /(SByte left, SByte right) {
			if (left._value is sbyte l) {
				if (right._value is sbyte r) {
					return (sbyte)(l / r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static sbyte operator %(SByte left, SByte right) {
			if (left._value is sbyte l) {
				if (right._value is sbyte r) {
					return (sbyte)(l % r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class UShort : BaseValueType {
		public UShort(object value = null) : base(value) { }

		#region binary operators overloaded

		public static ushort operator +(UShort left, UShort right) {
			if (left._value is ushort l) {
				if (right._value is ushort r) {
					return (ushort)(l + r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ushort operator -(UShort left, UShort right) {
			if (left._value is ushort l) {
				if (right._value is ushort r) {
					return (ushort)(l - r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ushort operator *(UShort left, UShort right) {
			if (left._value is ushort l) {
				if (right._value is ushort r) {
					return (ushort)(l * r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ushort operator /(UShort left, UShort right) {
			if (left._value is ushort l) {
				if (right._value is ushort r) {
					return (ushort)(l / r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ushort operator %(UShort left, UShort right) {
			if (left._value is ushort l) {
				if (right._value is ushort r) {
					return (ushort)(l % r);
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class UInteger : BaseValueType {
		public UInteger(object value = null) : base(value) { }

		#region binary operators overloaded

		public static uint operator +(UInteger left, UInteger right) {
			if (left._value is uint l) {
				if (right._value is uint r) {
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

		public static uint operator -(UInteger left, UInteger right) {
			if (left._value is uint l) {
				if (right._value is uint r) {
					return l - r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static uint operator *(UInteger left, UInteger right) {
			if (left._value is uint l) {
				if (right._value is uint r) {
					return l * r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static uint operator /(UInteger left, UInteger right) {
			if (left._value is uint l) {
				if (right._value is uint r) {
					return l / r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static uint operator %(UInteger left, UInteger right) {
			if (left._value is uint l) {
				if (right._value is uint r) {
					return l % r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class ULong : BaseValueType {
		public ULong(object value = null) : base(value) { }

		#region binary operators overloaded

		public static ulong operator +(ULong left, ULong right) {
			if (left._value is ulong l) {
				if (right._value is ulong r) {
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

		public static ulong operator -(ULong left, ULong right) {
			if (left._value is ulong l) {
				if (right._value is ulong r) {
					return l - r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ulong operator *(ULong left, ULong right) {
			if (left._value is ulong l) {
				if (right._value is ulong r) {
					return l * r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ulong operator /(ULong left, ULong right) {
			if (left._value is ulong l) {
				if (right._value is ulong r) {
					return l / r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static ulong operator %(ULong left, ULong right) {
			if (left._value is ulong l) {
				if (right._value is ulong r) {
					return l % r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class Float : BaseValueType {
		public Float(object value = null) : base(value) { }

		#region binary operators overloaded

		public static float operator +(Float left, Float right) {
			if (left._value is float l) {
				if (right._value is float r) {
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

		public static float operator -(Float left, Float right) {
			if (left._value is float l) {
				if (right._value is float r) {
					return l - r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static float operator *(Float left, Float right) {
			if (left._value is float l) {
				if (right._value is float r) {
					return l * r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static float operator /(Float left, Float right) {
			if (left._value is float l) {
				if (right._value is float r) {
					return l / r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static float operator %(Float left, Float right) {
			if (left._value is float l) {
				if (right._value is float r) {
					return l % r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class Double : BaseValueType {
		public Double(object value = null) : base(value) { }

		#region binary operators overloaded

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

		public static double operator -(Double left, Double right) {
			if (left._value is double l) {
				if (right._value is double r) {
					return l - r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static double operator *(Double left, Double right) {
			if (left._value is double l) {
				if (right._value is double r) {
					return l * r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static double operator /(Double left, Double right) {
			if (left._value is double l) {
				if (right._value is double r) {
					return l / r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static double operator %(Double left, Double right) {
			if (left._value is double l) {
				if (right._value is double r) {
					return l % r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}

	public class Decimal : BaseValueType {
		public Decimal(object value = null) : base(value) { }

		#region binary operators overloaded

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

		public static decimal operator -(Decimal left, Decimal right) {
			if (left._value is decimal l) {
				if (right._value is decimal r) {
					return l - r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static decimal operator *(Decimal left, Decimal right) {
			if (left._value is decimal l) {
				if (right._value is decimal r) {
					return l * r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static decimal operator /(Decimal left, Decimal right) {
			if (left._value is decimal l) {
				if (right._value is decimal r) {
					return l / r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		public static decimal operator %(Decimal left, Decimal right) {
			if (left._value is decimal l) {
				if (right._value is decimal r) {
					return l % r;
				}
				else {
					throw new InvalidCastException(ErrorMessage.RightTypeErrMsg(right.GetType()));
				}
			}
			else {
				throw new InvalidCastException(ErrorMessage.LeftTypeErrMsg(left.GetType()));
			}
		}

		#endregion
	}
}
