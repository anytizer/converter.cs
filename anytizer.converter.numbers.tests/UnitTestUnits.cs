using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestUnits
    {
        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod00()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(0);
            Assert.AreEqual("शुन्ना", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod01()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1);
            Assert.AreEqual("एक", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod08()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(8);
            Assert.AreEqual("आठ", value);
        }
    }
}
