using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestPadma
    {
        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1234567890987654321()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(1234567890987654321L); // "12345678909876518"
            Assert.AreEqual("बाह्र पद्म चौंतीस शंख छपन्न नील अठहत्तर खर्ब नब्बे अर्ब अन्ठानब्बे करोड छहत्तर लाख चौवन्न हजार तीन सय एक्काइस", value);
        }

        [TestMethod]
        [TestCategory("Conversion Test")]
        public void TestMethod1234567890987654321S()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari("1234567890987654321");
            Assert.AreEqual("बाह्र पद्म चौंतीस शंख छपन्न नील अठहत्तर खर्ब नब्बे अर्ब अन्ठानब्बे करोड छहत्तर लाख चौवन्न हजार तीन सय एक्काइस", value);
        }
    }
}
