using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared;

namespace Tests
{
    [TestClass]
    public class TestExtensions
    {
        [TestMethod]
        public void IntIsEven()
        {
            int n = 4;

            bool result = n.IsEven();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntIsNotEven()
        {
            int n = 5;

            bool result = n.IsEven();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LongIsEven()
        {
            long n = long.MaxValue - 1;

            bool result = n.IsEven();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LongIsNotEven()
        {
            long n = long.MaxValue;

            bool result = n.IsEven();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LongIsPrime()
        {
            long n = 922_337_203_369;

            bool result = n.IsPrime();

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void LongIsNotPrime()
        {
            long n = 922_337_203_367;

            bool result = n.IsPrime();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetPrimeFactors()
        {
            long n = 10;

            long result = n.GetPrimeFactors().Last();

            Assert.AreEqual(result, 5);
        }
    }
}
