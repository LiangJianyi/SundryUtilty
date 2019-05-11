using System;
using System.Numerics;

namespace Janyee.Utilty {
    public static class BigIntegerExtension {
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
