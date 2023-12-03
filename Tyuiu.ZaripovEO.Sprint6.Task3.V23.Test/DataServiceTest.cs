using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaripovEO.Sprint6.Task3.V23.Lib;

namespace Tyuiu.ZaripovEO.Sprint6.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 0, -19, 25, 34, 0 }, { -19, -16, 1, -5, 34 }, { 1, 13, -5, -17, -5 }, { 3, -9, -15, -1, 0 }, { 1, 20, 15, -5, 31 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { 0, -19, 25, 34, 0 }, { -19, -16, 1, -5, 34 }, { 1, -9, -5, -17, -5 }, { 3, 13, -15, -1, 0 }, { 1, 20, 15, -5, 31 } }; ;
            CollectionAssert.AreEqual(mas2, wait);
        }
    }
}
