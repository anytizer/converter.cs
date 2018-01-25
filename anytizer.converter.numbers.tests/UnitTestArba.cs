using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestArba
    {
        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod5987654321()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(5987654321);
            Assert.AreEqual("पाँच अर्ब अन्ठानब्बे करोड छहत्तर लाख चौवन्न हजार तीन सय एक्काइस", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod70000032100()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(70000032100);
            Assert.AreEqual("सत्तरी अर्ब बत्तीस हजार एक सय", value);
        }
    }
}
