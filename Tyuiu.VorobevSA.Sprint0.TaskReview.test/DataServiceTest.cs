using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint0.TaskReview.lib;

namespace Tyuiu.VorobevSA.Sprint0.TaskReview.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(45, DataService.Calc(2, 3, 4));
        }
    }
}
