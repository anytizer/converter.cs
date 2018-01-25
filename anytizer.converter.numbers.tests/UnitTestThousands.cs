using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestThousands
    {
        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1000()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1000);
            Assert.AreEqual("एक हजार", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1007()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1007);
            Assert.AreEqual("एक हजार सात", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1041()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1041);
            Assert.AreEqual("एक हजार एकचालीस", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1200()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1200);
            Assert.AreEqual("एक हजार दुइ सय", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1241()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1241);
            Assert.AreEqual("एक हजार दुइ सय एकचालीस", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1280()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1280);
            Assert.AreEqual("एक हजार दुइ सय असी", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1597()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1597);
            Assert.AreEqual("एक हजार पाँच सय सन्तानब्बे", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod50007()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(50007);
            Assert.AreEqual("पचास हजार सात", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod50250()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(50250);
            Assert.AreEqual("पचास हजार दुइ सय पचास", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod54597()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(54597);
            Assert.AreEqual("चौवन्न हजार पाँच सय सन्तानब्बे", value);
        }
    }
}
