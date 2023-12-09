using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaripovEO.Sprint6.Task7.V6.Lib;

namespace Tyuiu.ZaripovEO.Sprint6.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\zarip\source\repos\Tyuiu.ZaripovEO.Sprint6\Tyuiu.ZaripovEO.Sprint6.Task7.V6\bin\Release\InPutFileTask7V6.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] wait = {
                { -14,  -1,   2,  18,  -17,   7, -16,  0,  12,  17 },
                {   8, -17,  10, -19,   -4, -11,   8,  0, -15,  -8 },
                { -14,  -5, -10,   -20,  19,   -3,   -19, 0,   -10,  8 },
                {   3,  17,   -10, -9,  -1,   18,   -10, 0,   17,  15 },
                {   7,  16,   0,   9,   -3,   14,   12, 0, 10, 6 },
                {  -1,  17,  -3,  20,   11,  14,   -15, 0,   -4,  -6 },
                {  -9,  -8,   7,   13,  4, 5,   13, 0,  -19,   12 },
                {  -8,  -7,  3, 3,    -18, -13,   -11, 0,  -1,   -12 },
                {  -11, -18,  2, -6,    -9,  -18,   -16, 0,  1,  -13 },
                {  12, -13,   7,   20,  9, -8,   8, 0,  6,-18 }
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
        
    

