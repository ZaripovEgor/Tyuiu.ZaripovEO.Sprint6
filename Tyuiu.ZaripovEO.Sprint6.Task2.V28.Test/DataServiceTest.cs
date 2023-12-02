using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaripovEO.Sprint6.Task2.V28.Lib;

namespace Tyuiu.ZaripovEO.Sprint6.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startVal = -5;
            int stopVal = 5;
            int len = stopVal - startVal + 1;

            double[] WaitArray;
            WaitArray = new double[len];

            WaitArray[0] = 17.27;
            WaitArray[1] = 14.08;
            WaitArray[2] = 10.27;
            WaitArray[3] = 6.65;
            WaitArray[4] = 3.87;
            WaitArray[5] = 2;
            WaitArray[6] = -0.74;
            WaitArray[7] = -3.71;
            WaitArray[8] = -7.59;
            WaitArray[9] = -11.55;
            WaitArray[10] = -14.74;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startVal, stopVal);
            CollectionAssert.AreEqual(WaitArray, res);

        }
    }
}
