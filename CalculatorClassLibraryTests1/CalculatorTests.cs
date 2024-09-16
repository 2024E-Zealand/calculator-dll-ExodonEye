using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //arrange
            int a = 4; 
            int b = 5;
            int expected = 9;

            //act
            int result = Calculator.Add(a, b);

            //assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void AddTestFail()
        {
            //arrange
            int a = 4;
            int b = 5;
            int expected = 10;

            //act
            int result = Calculator.Add(a, b);

            //assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            //arrange
            int a = 4;
            int b = 5;
            int expected = -1;

            //act
            int result = Calculator.Subtract(a, b);

            //assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void SubtractTestFail()
        {
            //arrange
            int a = 4;
            int b = 5;
            int expected = 1;

            //act
            int result = Calculator.Subtract(a, b);

            //assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //arrange
            int a = 2;
            int b = 5;
            int expected = 10;

            //act
            int result = Calculator.Multiply(a, b);

            //assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void MultiplyTestFail()
        {
            //arrange
            int a = 2;
            int b = 5;
            int expected = 2;

            //act
            int result = Calculator.Multiply(a, b);

            //assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod()]
        public void DivideTest()
        { 
            //arrange
            int a = 4;
            int b = 2;
            int expected = 2;

            //act
            int result = Calculator.Divide(a, b);

            //assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void DivideTestFail()
        {
            //arrange
            int a = 4;
            int b = 2;
            int expected = -2;

            //act
            int result = Calculator.Divide(a, b);

            //assert
            Assert.AreNotEqual(expected, result);
        }



    }
}