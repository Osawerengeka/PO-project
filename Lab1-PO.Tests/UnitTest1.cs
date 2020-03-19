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
            string s = "kilo";
            int exp = 34668;
            int a;
            MainClass m = new MainClass();
            int a = m.hashfunc(s);
            Assert.AreEqual(exp,a);
        }
        [TestMethod]
        public void Authchecklog()
        {
            string login = "250824";
            MainClass m = new MainClass();
            
            Assert.IsTrue(m.IsUnic(login));
        }
    }
}
