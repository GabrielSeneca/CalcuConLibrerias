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
            string result = CalcuconLibrerias.Program.Suma();
            Assert.AreEqual("15", result);

            string result2 = CalcuconLibrerias.Program.Multi();
            Assert.AreEqual("50", result2);
        }
    }
}
