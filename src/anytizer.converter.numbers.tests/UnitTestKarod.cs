using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestKarod
    {
        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod87654321()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(87654321);
            Assert.AreEqual("आठ करोड छहत्तर लाख चौवन्न हजार तीन सय एक्काइस", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod987654321()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(987654321);
            Assert.AreEqual("अन्ठानब्बे करोड छहत्तर लाख चौवन्न हजार तीन सय एक्काइस", value);
        }
    }
}
