using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            double result = CalculatorEngine.Add(10.0, 20.0);

            Assert.AreEqual(30.0, result);            
        }


        [TestMethod]
        public void TestSubtractMethod()
        {
            double result = CalculatorEngine.Subtract(10.0, 20.0);

            Assert.AreEqual(-10.0, result);
        }
    }
}
