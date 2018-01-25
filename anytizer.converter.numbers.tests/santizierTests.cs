using anytizer.converter.numbers;
using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass()]
    public class SantizierTests
    {
        [TestMethod()]
        public void SanitizeDecimalsTest()
        {
            santizier s = new santizier();
            string v = s.Sanitize("5.67");

            Assert.AreEqual("5", v);
        }

        [TestMethod()]
        public void SanitizeDecimals2Test()
        {
            santizier s = new santizier();
            string v = s.Sanitize("5,001.97");

            Assert.AreEqual("5001", v);
        }
    }
}