using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestKharba
    {
        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod800000000100()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(800000000100);
            Assert.AreEqual("आठ खर्ब एक सय", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod9000000000000()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(9000000000000);
            Assert.AreEqual("नब्बे खर्ब", value);
        }
    }
}
