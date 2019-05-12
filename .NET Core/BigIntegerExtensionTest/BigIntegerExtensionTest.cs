using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using Janyee.Utilty;

namespace BigIntegerExtensionTest {
    [TestClass]
    public class BigIntegerExtensionTest {
        [TestMethod]
        public void BigIntegerToInt16Test() {
            short i = short.MaxValue;
            while (true) {
                if (i == 0) {
                    short b = new BigInteger(i).BigIntegerToInt16(); ;
                    Assert.AreEqual<short>(i, b);
                    break;
                }
                else {
                    short b = new BigInteger(i).BigIntegerToInt16(); ;
                    Assert.AreEqual<short>(i, b);
                    i /= 10;
                }
            }
            i = short.MinValue;
            while (true) {
                if (i < 0) {
                    short b = new BigInteger(i).BigIntegerToInt16(); ;
                    Assert.AreEqual<short>(i, b);
                    i /= 10;
                }
                else {
                    short b = new BigInteger(i).BigIntegerToInt16(); ;
                    Assert.AreEqual<short>(i, b);
                    break;
                }
            }
        }

        [TestMethod]
        public void BigIntegerToUInt16Test() {
            ushort i = ushort.MaxValue;
            while (true) {
                if (i == 0) {
                    ushort b = new BigInteger(i).BigIntegerToUInt16(); ;
                    Assert.AreEqual<ushort>(i, b);
                    break;
                }
                else {
                    ushort b = new BigInteger(i).BigIntegerToUInt16(); ;
                    Assert.AreEqual<ushort>(i, b);
                    i /= 10;
                }
            }
        }

        [TestMethod]
        public void BigIntegerToInt32Test() {
            int i = int.MaxValue;
            while (true) {
                if (i == 0) {
                    int b = new BigInteger(i).BigIntegerToInt32(); ;
                    Assert.AreEqual<int>(i, b);
                    break;
                }
                else {
                    int b = new BigInteger(i).BigIntegerToInt32(); ;
                    Assert.AreEqual<int>(i, b);
                    i /= 10;
                }
            }
            i = int.MinValue;
            while (true) {
                if (i < 0) {
                    int b = new BigInteger(i).BigIntegerToInt32(); ;
                    Assert.AreEqual<int>(i, b);
                    i /= 10;
                }
                else {
                    int b = new BigInteger(i).BigIntegerToInt32(); ;
                    Assert.AreEqual<int>(i, b);
                    break;
                }
            }
        }

        [TestMethod]
        public void BigIntegerToUInt32Test() {
            uint i = uint.MaxValue;
            while (true) {
                if (i == 0) {
                    uint b = new BigInteger(i).BigIntegerToUInt32(); ;
                    Assert.AreEqual<uint>(i, b);
                    break;
                }
                else {
                    uint b = new BigInteger(i).BigIntegerToUInt32(); ;
                    Assert.AreEqual<uint>(i, b);
                    i /= 10;
                }
            }
        }

        [TestMethod]
        public void BigIntegerToInt64Test() {
            long i = long.MaxValue;
            while (true) {
                if (i == 0) {
                    long b = new BigInteger(i).BigIntegerToInt64(); ;
                    Assert.AreEqual<long>(i, b);
                    break;
                }
                else {
                    long b = new BigInteger(i).BigIntegerToInt64(); ;
                    Assert.AreEqual<long>(i, b);
                    i /= 10;
                }
            }
            i = long.MinValue;
            while (true) {
                if (i < 0) {
                    long b = new BigInteger(i).BigIntegerToInt64(); ;
                    Assert.AreEqual<long>(i, b);
                    i /= 10;
                }
                else {
                    long b = new BigInteger(i).BigIntegerToInt64(); ;
                    Assert.AreEqual<long>(i, b);
                    break;
                }
            }
        }

        [TestMethod]
        public void BigIntegerToUInt64Test() {
            ulong i = ulong.MaxValue;
            while (true) {
                if (i == 0) {
                    ulong b = new BigInteger(i).BigIntegerToUInt64(); ;
                    Assert.AreEqual<ulong>(i, b);
                    break;
                }
                else {
                    ulong b = new BigInteger(i).BigIntegerToUInt64(); ;
                    Assert.AreEqual<ulong>(i, b);
                    i /= 10;
                }
            }
        }
    }
}
