using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint0.Task4.V0.lib;

namespace Tyuiu.VorobevSA.Sprint0.Task4.V0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChechAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void ChechSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void ChechMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void ChechDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }

    }
}
