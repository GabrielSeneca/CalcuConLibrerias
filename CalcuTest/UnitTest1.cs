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

            //string result2 = CalcuconLibrerias.Program.Multi();
            // Assert.AreEqual("50", result2);

            //Arrange
            double a = 10;
            double b = 5;
            double expected = 50;
            
            //Act
            double result = CalcuconLibrerias.Program.Multi();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataRow(50, 10, 5)]
        [TestMethod]
        public void Div_shouldcalcandreturnsamevalue(double a, double b, double expected)
        {

            //arrange

            //act
            double actual = CalcuconLibrerias.Program.Div();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
