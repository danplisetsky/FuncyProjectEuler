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
            long n = 13195;
            long n1 = 4;

            long result = n.GetPrimeFactors().Last();
            int result1 = n1.GetPrimeFactors().Count();

            Assert.AreEqual(result, 29);
            Assert.AreEqual(result1, 1);
        }

        [TestMethod]
        public void IsPalindrome()
        {
            int n = 1234321;

            bool result = n.IsPalindrome();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntToPow()
        {
            int n = 2, pow = 8;

            double result = n.Pow(pow);

            Assert.AreEqual(result, 256);
        }

        [TestMethod]
        public void TripletTupleProduct()
        {
            var triplet = (3, 4, 5);

            long result = triplet.Product();

            Assert.AreEqual(result, 60);
        }

        [TestMethod]
        public void TupleIsPythagoreanTriplet()
        {
            var triplet = (3, 4, 5);
            var triplet1 = (3, 4, 6);

            bool result = triplet.IsPythagoreanTriplet();
            bool result1 = triplet1.IsPythagoreanTriplet();

            Assert.IsTrue(result);
            Assert.IsFalse(result1);
        }

        [TestMethod]
        public void NumberOfFactors()
        {
            long n = 28;
            long n1 = 16;

            int result = n.GetNumberOfFactors();
            int result1 = n1.GetNumberOfFactors();

            Assert.AreEqual(result, 6);
            Assert.AreEqual(result1, 5);
        }

        [TestMethod]
        public void CollatzSequenceLength()
        {
            long n = 13;

            int result = n.CollatzSequenceLength();

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void IsAmicablePair()
        {
            long a = 220, b = 284, c = 10;

            bool result = a.IsAmicablePairOf(b);
            bool result2 = a.IsAmicablePairOf(c);

            Assert.IsTrue(result);
            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void IsAbundant()
        {
            long n = 12;

            bool result = n.IsAbundant();

            Assert.IsTrue(result);
        }
    }
}
