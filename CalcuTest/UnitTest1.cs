using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculos;

namespace CalcuTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Suma_ShouldCalcAndReturnSameValue()
        {
            string result = CalcuconLibrerias.Program.Suma();
            Assert.AreEqual("15", result);

        }

        [TestMethod]
        public void Multi_ShouldCalcAndReturnSameValue()
        {

            //Arrange
            //double a = 10;
            //double b = 5;
            double expected = 50;
            
            //Act
            double result = CalcuconLibrerias.Program.Multi();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataRow(50, 10, 5)]
        [TestMethod]
        public void Div_ShouldCalcAndReturnSameValue(double a, double b, double expected)
        {

            //arrange

            //act
            double result = CalcuconLibrerias.Program.Div();

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataRow(100,0)]
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void test_Exception()
        {
            //double a = 100;
            //double b = 0;
            double result = CalcuconLibrerias.Program.Div();
        }
    }
}
