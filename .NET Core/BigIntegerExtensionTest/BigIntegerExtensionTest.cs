using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using Janyee.Utilty;

namespace BigIntegerExtensionTest {
    [TestClass]
    public class BigIntegerExtensionTest {
        [TestMethod]
        public void BigIntegerToInt32Test() {
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
