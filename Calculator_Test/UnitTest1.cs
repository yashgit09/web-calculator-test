using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_Test
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc;
        
        [TestInitialize]

        //instantiating calculator object
        public void Instantiate()
        {
            calc = new Calculator();
        }

        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }

        
        [TestMethod]
        public void CalculatorClassIsInstantiable()
        {
            Assert.IsNotNull(calc);
        }

        //test methods for testing the addition of whole numbers, decimals and zero
        [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        public void CalculatorCanAddTwoPositiveNumbersAddTest1(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-25, -10, -15)]
        public void CalculatorCanAddTwoNegativeNumbersAddTest2(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-8, 2, -10)]
        public void CalculatorCanAddPositiveNegativeNumbersAddTest3(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(1, -4, 5)]
        public void CalculatorCanAddNegativePositiveNumbersAddTest4(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(10, 10, 0)]
        public void CalculatorCanAddZeroAndPositiveNumbersAddTest5(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-2, -2, 0)]
        public void CalculatorCanAddZeroAndNegativeNumbersAddTest6(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(7.8, 2.3, 5.5)]
        public void CalculatorCanAddDecimalPositiveNumbersAddTest7(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-7.1, -4.3, -2.8)]
        public void CalculatorCanAddDecimalNegativeNumbersAddTest8(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-4.6, 0, -4.6)]
        public void CalculatorCanAddDecimalZeroAndNegativeNumbersAddTest9(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(10.5, 10.5, 0)]
        public void CalculatorCanAddDecimalAndZeroNumbersAddTest10(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

    }
}
