using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared;

namespace Tests
{
    [TestClass]
    public class TestExtensions
    {
        [TestMethod]
        public void IsEven()
        {
            int n = 4;

            bool result = n.IsEven();

            Assert.IsTrue(result);
        }
    }
}
