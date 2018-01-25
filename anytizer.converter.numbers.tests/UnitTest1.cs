using anytizer.converter.numbers.values;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace anytizer.converter.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            string n = Regex.Replace("-1.00", "[^0-9]", "");
            Assert.AreEqual("100", n);
        }

        [TestMethod]
        public void TestMethod3()
        {
            santizier s = new santizier();
            string n = s.Sanitize("-1.00");
            Assert.AreEqual("1", n);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string n = Regex.Replace("one two  three   four    five", "([ ]+)", " ");
            Assert.AreEqual("one two three four five", n);
        }
    }   
}