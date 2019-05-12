using System;
using System.Numerics;

/*
 * 每个方法都有一个 else if (bytes.Length < sizeof(T)) 分支，
 * 该分支专门处理 BigInteger 实参的长度小于 sizeof(T) 的情况，
 * 先创建一个与 T 长度等价的 res 字节数组，然后将 BigInteger 
 * 对应的字节数组填充到 res 数组，最后通过 BitConverter 产生
 * 最终的结果。
 * 注意：正数和负数有不同的处理方式（尤其是用来转换有符号整数的方法中）。
 * 正数需要在 res 比 bytes 多出的部分补零（其实什么都不用干，保留元素的默认值），
 * 负数需要在 res 比 bytes 多出的部分补FF（将元素的值改为 255，因为这是负数的补码形式），
 * 具体的实现细节在 if (bi.Sign == -1) 内部的循环中。
 * 比如有个值为 -9223372036854775 的 BigInteger 对象，
 * 它的字节码为 09 AC 1C 5A 64 3B DF ，要想把它转为 Int64，就要在后面追加 FF
 * 扩充为 64 位长度的字节码，否则 BitConverter 会把它转换为一个正整数。
 * 
 * 根据文档 https://docs.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=netframework-4.8
 * BigInteger 通常会为正数追加一个值为0的附加字节。
 * 情况 else if (bytes.Length == sizeof(T) + 1) 专门负责这一点。
 */

namespace Janyee.Utilty {
    public static class BigIntegerExtension {
        public static short BigIntegerToInt16(this BigInteger bi) {
            byte[] bytes = bi.ToByteArray();
            if (bytes.Length == sizeof(short)) {
                return BitConverter.ToInt16(bytes);
            }
            else if (bytes.Length == sizeof(short) + 1) {
                byte[] res = new byte[sizeof(short)];
                Array.Copy(bytes, res, bytes.Length - 1);
                return BitConverter.ToInt16(res);
            }
            else if (bytes.Length < sizeof(short)) {
                byte[] res = new byte[sizeof(short)];
                Array.Copy(bytes, res, bytes.Length);
                if (bi.Sign == -1) {
                    for (int i = 0; i < res.Length; i++) {
                        if (res[i] == 0 && i >= bytes.Length) {
                            res[i] = 255;
                        }
                    }
                }
                return BitConverter.ToInt16(res);
            }
            else {
                throw new ArgumentOutOfRangeException($"bi={bi}", "The bytes length of BigInteger larger than Int32.");
            }
        }

        public static ushort BigIntegerToUInt16(this BigInteger bi) {
            byte[] bytes = bi.ToByteArray();
            if (bytes.Length == sizeof(ushort)) {
                return BitConverter.ToUInt16(bytes);
            }
            else if (bytes.Length == sizeof(ushort) + 1) {
                byte[] res = new byte[sizeof(ushort)];
                Array.Copy(bytes, res, bytes.Length - 1);
                return BitConverter.ToUInt16(res);
            }
            else if (bytes.Length < sizeof(ushort)) {
                byte[] res = new byte[sizeof(ushort)];
                Array.Copy(bytes, res, bytes.Length);
                if (bi.Sign == -1) {
                    for (int i = 0; i < res.Length; i++) {
                        if (res[i] == 0 && i >= bytes.Length) {
                            res[i] = 255;
                        }
                    }
                }
                return BitConverter.ToUInt16(res);
            }
            else {
                throw new ArgumentOutOfRangeException($"bi={bi}", "The bytes length of BigInteger larger than Int32.");
            }
        }

        public static int BigIntegerToInt32(this BigInteger bi) {
            byte[] bytes = bi.ToByteArray();
            if (bytes.Length == sizeof(int)) {
                return BitConverter.ToInt32(bytes);
            }
            else if (bytes.Length == sizeof(int) + 1) {
                byte[] res = new byte[sizeof(int)];
                Array.Copy(bytes, res, bytes.Length - 1);
                return BitConverter.ToInt32(res);
            }
            else if (bytes.Length < sizeof(int)) {
                byte[] res = new byte[sizeof(int)];
                Array.Copy(bytes, res, bytes.Length);
                if (bi.Sign == -1) {
                    for (int i = 0; i < res.Length; i++) {
                        if (res[i] == 0 && i >= bytes.Length) {
                            res[i] = 255;
                        }
                    }
                }
                return BitConverter.ToInt32(res);
            }
            else {
                throw new ArgumentOutOfRangeException($"bi={bi}", "The bytes length of BigInteger larger than Int32.");
            }
        }

        public static uint BigIntegerToUInt32(this BigInteger bi) {
            byte[] bytes = bi.ToByteArray();
            if (bytes.Length == sizeof(uint)) {
                return BitConverter.ToUInt32(bytes);
            }
            else if (bytes.Length == sizeof(uint) + 1) {
                byte[] res = new byte[sizeof(uint)];
                Array.Copy(bytes, res, bytes.Length - 1);
                return BitConverter.ToUInt32(res);
            }
            else if (bytes.Length < sizeof(uint)) {
                byte[] res = new byte[sizeof(uint)];
                Array.Copy(bytes, res, bytes.Length);
                return BitConverter.ToUInt32(res);
            }
            else {
                throw new ArgumentOutOfRangeException($"bi={bi}", "The bytes length of BigInteger larger than UInt32.");
            }
        }

        public static long BigIntegerToInt64(this BigInteger bi) {
            byte[] bytes = bi.ToByteArray();
            if (bytes.Length == sizeof(long)) {
                return BitConverter.ToInt64(bytes);
            }
            else if (bytes.Length == sizeof(long) + 1) {
                byte[] res = new byte[sizeof(long)];
                Array.Copy(bytes, res, bytes.Length - 1);
                return BitConverter.ToInt64(res);
            }
            else if (bytes.Length < sizeof(long)) {
                byte[] res = new byte[sizeof(long)];
                Array.Copy(bytes, res, bytes.Length);
                if (bi.Sign == -1) {
                    for (int i = 0; i < res.Length; i++) {
                        if (res[i] == 0 && i >= bytes.Length) {
                            res[i] = 255;
                        }
                    }
                }
                return BitConverter.ToInt64(res);
            }
            else {
                throw new ArgumentOutOfRangeException($"bi={bi}", "The bytes length of BigInteger larger than Int64.");
            }
        }

        public static ulong BigIntegerToUInt64(this BigInteger bi) {
            byte[] bytes = bi.ToByteArray();
            if (bytes.Length == sizeof(ulong)) {
                return BitConverter.ToUInt64(bytes);
            }
            else if (bytes.Length == sizeof(ulong) + 1) {
                byte[] res = new byte[sizeof(ulong)];
                Array.Copy(bytes, res, bytes.Length - 1);
                return BitConverter.ToUInt64(res);
            }
            else if (bytes.Length < sizeof(ulong)) {
                byte[] res = new byte[sizeof(ulong)];
                Array.Copy(bytes, res, bytes.Length);
                return BitConverter.ToUInt64(res);
            }
            else {
                throw new ArgumentOutOfRangeException($"bi={bi}", "The bytes length of BigInteger larger than UInt64.");
            }
        }
    }
}
