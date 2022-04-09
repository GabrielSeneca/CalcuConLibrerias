using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcuTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = CalcuconLibrerias.Program.Test();
            Assert.AreEqual("prueba test", result);
        }
    }
}
