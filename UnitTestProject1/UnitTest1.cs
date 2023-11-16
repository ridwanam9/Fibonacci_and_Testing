using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fibonacci1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            int input = 5; // You can change this value based on your test case
            int expected = 5; // You need to replace this with the expected result of Fibonacci(5)

            // Act
            int result = Program.Fibonacci(input);

            // Assert
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void Fibonacci_WithInput0_Returns0()
        {
            // Arrange
            int input = 0;
            int expected = 0;

            // Act
            int result = Program.Fibonacci(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
