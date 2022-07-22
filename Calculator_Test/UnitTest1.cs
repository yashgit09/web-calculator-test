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

        //test methods for testing the subtraction of whole numbers, decimals and zero
        [TestMethod]
        [DataRow(3, 15, 12)]
        public void CalculatorCanSubtractTwoPositiveNumbersSubtractTest1(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(0, -4, -4)]
        public void CalculatorCanSubtractTwoNegativeNumbersSubtractTest2(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }


        [TestMethod]
        [DataRow(-9, -1, 8)]
        public void CalculatorCanSubtractNegativePositiveNumbersSubtractTest3(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(6, 1, -5)]
        public void CalculatorCanSubtractPositiveNegativeNumbersSubtractTest4(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(1, 8.1, 7.1)]
        public void CalculatorCanSubtractDecimalPositiveNumbersSubtractTest5(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-1, -3.2, -2.2)]
        public void CalculatorCanSubtractDecimalNegativeNumbersSubtractTest6(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(7, 7, 0)]
        public void CalculatorCanSubtractZeroAndPositiveNumbersSubtractTest7(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-7, -7, 0)]
        public void CalculatorCanSubtractZeroAndNegativeNumbersSubtractTest8(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(4.6, 0, -4.6)]
        public void CalculatorCanSubtractDecimalZeroAndNegativeNumbersSubtractTest9(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(1.3, 1.3, 0)]
        public void CalculatorCanSubtractDecimalAndZeroNumbersSubtractTest10(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        //test methods for testing the multiplication of whole numbers, decimals and zero

        [TestMethod]
        [DataRow(8, 4, 2)]
        public void CalculatorMultipliesTwoPositiveNumbersMultiplyTest1(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(8, -4, -2)]
        public void CalculatorMultipliesTwoNegativeNumbersMultiplyTest2(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-8, 4, -2)]
        public void CalculatorMultipliesPositiveNegativeNumbersMultiplyTest3(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(2.7, 1.8, 1.5)]
        public void CalculatorMultipliesTwoPositiveDecimalNumbersMultiplyTest4(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Math.Round(calc.Multiply(left, right)), 1);
        }

        [TestMethod]
        [DataRow(2.7, -1.8, -1.5)]
        public void CalculatorMultipliesTwoNegativeDecimalNumbersMultiplyTest5(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Math.Round(calc.Multiply(left, right)), 1);
        }

        [TestMethod]
        [DataRow(-2.7, 1.8, -1.5)]
        public void CalculatorMultipliesPositiveAndNegativeDecimalNumbersMultiplyTest6(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Math.Round(calc.Multiply(left, right)), 1);
        }

        [TestMethod]
        [DataRow(0, 1.8, 0)]
        public void CalculatorMultipliesPositiveDecimalAndZeroMultiplyTest7(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, -1.8, 0)]
        public void CalculatorMultipliesNegativeDecimalAndZeroMultiplyTest8(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, 1, 0)]
        public void CalculatorMultipliesPositiveNumberAndZeroMultiplyTest9(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, -1, 0)]
        public void CalculatorMultipliesNegativeNumberAndZeroMultiplyTest10(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }





        //test methods for testing the division of whole numbers, decimals and zero
        [TestMethod]
        public void CalculatorThrowsExceptionWhenDividingByZeroDivideTest1()
        {
            Assert.ThrowsException<DivideByZeroException>(() => { calc.Divide(9, 0); });
        }

        [TestMethod]
        [DataRow(2, 8, 4)]
        public void CalculatorDividesTwoPositiveNumbersDivideTest2(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(2, -8, -4)]
        public void CalculatorDividesTwoNegativeNumbersDivideTest3(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-2, 8, -4)]
        public void CalculatorDividesPositiveNegativeNumbersDivideTest4(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-2, -8, 4)]
        public void CalculatorDividesNegativePositiveNumbersDivideTest5(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(0, 0, 4)]
        public void CalculatorDividesZeroInNumeratorPositiveDenominatorNumbersDivideTest6(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(0, 0, -4)]
        public void CalculatorDividesZeroInNumeratorNegativeDenominatorNumbersDivideTest7(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(3, 3.9, 1.3)]
        public void CalculatorDividesTwoPositiveDecimalNumbersDivideTest8(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(3.0, -3.9, -1.3)]
        public void CalculatorDividesTwoNegativeDecimalNumbersDivideTest9(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-3.0, 3.9, -1.3)]
        public void CalculatorDividesPositiveNegativeDecimalNumbersDivideTest10(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }



    }
}
