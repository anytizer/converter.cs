using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anytizer.converter.tests
{
    [TestClass]
    public class SubstringTests
    {
        [TestMethod]
        public void TestSubstring021()
        {
            string n = "321";
            string tens = n.Substring(n.Length-2, 2);
            Assert.AreEqual("21", tens);
        }

        [TestMethod]
        public void TestSubstring300()
        {
            string n = "321";
            string hundreds = n.Substring(n.Length - 3, 1);
            Assert.AreEqual("3", hundreds);
        }

        [TestMethod]
        public void TestSubstring4000()
        {
            string n = "4321";
            string thousands = n.Substring(n.Length - 4, 1);
            Assert.AreEqual("4", thousands);
        }

        [TestMethod]
        public void TestSubstring54000()
        {
            string n = "54321";
            string thousands = n.Substring(n.Length - 5, 2);
            Assert.AreEqual("54", thousands);
        }
    }   
}



