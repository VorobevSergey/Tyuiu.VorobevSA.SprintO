using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint0.Task6.V0.lib;

namespace Tyuiu.VorobevSA.Sprint0.Task6.V0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
