using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.UleevRI.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(num);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckedSubtactionArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(num);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckedMultiplicationArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(num);
            Assert.AreEqual(120, res);
        }
    }
}
