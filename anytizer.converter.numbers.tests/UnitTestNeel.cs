using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestNeel
    {
        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod999999999999999()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(999999999999999);
            Assert.AreEqual("उनान्सय नील उनान्सय खर्ब उनान्सय अर्ब उनान्सय करोड उनान्सय लाख उनान्सय हजार नौ सय उनान्सय", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod9898989898989898()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(989898989898989);
            Assert.AreEqual("अन्ठानब्बे नील अन्ठानब्बे खर्ब अन्ठानब्बे अर्ब अन्ठानब्बे करोड अन्ठानब्बे लाख अन्ठानब्बे हजार नौ सय उनान्नब्बे", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod123456789098765()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(123456789098765); // "123456789098765"
            Assert.AreEqual("बाह्र नील चौंतीस खर्ब छपन्न अर्ब अठहत्तर करोड नब्बे लाख अन्ठानब्बे हजार सात सय पैंसठ्ठी", value);
        }
    }
}
