using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1_PO.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void hash1()
        {
            string s = "wsdma";
            int exp = 75;
            MainClass m = new MainClass();
            int a = m.hashfunc(s);
            Assert.AreEqual(exp,a);
        }
    }
}
