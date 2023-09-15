using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint0.Task7.V0.Lib;

namespace Tyuiu.UleevRI.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            int[] a = new int[] { 1, 1, 1, 1, 1 };
            int[] b = new int[] { 1, 1, 1, 1, 1 };
            int[] c = new int[] { 2, 2, 2, 2, 2 };
            int[] num = DataService.AdditionArrays(a, b);
            CollectionAssert.AreEqual(num, c);
        }
    }
}
