using System;
using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestTens
    {
       [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod099()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(99);
            Assert.AreEqual("उनान्सय", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod31()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(31);
            Assert.AreEqual("एकतीस", value);
        }
    }
}
