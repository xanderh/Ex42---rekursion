using System;
using Ex42___rekursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactorial()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.Factorial(0));
            Assert.AreEqual(1, Program.Factorial(1));
            Assert.AreEqual(2, Program.Factorial(2));
            Assert.AreEqual(6, Program.Factorial(3));
        }

        [TestMethod]
        public void TestFibonacci()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.Fibonacci(-1));
            Assert.AreEqual(0, Program.Fibonacci(0));
            Assert.AreEqual(1, Program.Fibonacci(1));
            Assert.AreEqual(2, Program.Fibonacci(3));
            Assert.AreEqual(5, Program.Fibonacci(5));
            Assert.AreEqual(8, Program.Fibonacci(6));
        }

        [TestMethod]
        public void TestFibonacciFast()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.FibonacciFast(-1));
            Assert.AreEqual(0UL, Program.FibonacciFast(0));
            Assert.AreEqual(1UL, Program.FibonacciFast(1));
            Assert.AreEqual(2UL, Program.FibonacciFast(3));
            Assert.AreEqual(5UL, Program.FibonacciFast(5));
            Assert.AreEqual(8UL, Program.FibonacciFast(6));
        }
    }
}
