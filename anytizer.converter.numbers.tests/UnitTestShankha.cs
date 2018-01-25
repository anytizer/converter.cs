using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTestShankha
    {
        [TestMethod]
        public void TestMethod12345678909876543()
        {
            NumberConverter nc = new NumberConverter();
            string value = nc.ToDevnagari(12345678909876543L); // "12345678909876518"
            Assert.AreEqual("बाह्र शंख चौंतीस नील छपन्न खर्ब अठहत्तर अर्ब नब्बे करोड अन्ठानब्बे लाख छहत्तर हजार पाँच सय सोह्र", value);
            Assert.Fail();
        }
    }
}

