using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestHundreds
    {
        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod400()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(400);
            Assert.AreEqual("चार सय", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod502()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(502);
            Assert.AreEqual("पाँच सय दुइ", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod660()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(660);
            Assert.AreEqual("छ सय साठी", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod131()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(131);
            Assert.AreEqual("एक सय एकतीस", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod900()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(900);
            Assert.AreEqual("नौ सय", value);
        }
    }
}
