using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaripovEO.Sprint6.Task1.V13.Lib;

namespace Tyuiu.ZaripovEO.Sprint6.Task1.V13.Test
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

            WaitArray[0] = 23.92;
            WaitArray[1] = 18.88;
            WaitArray[2] = 13.10;
            WaitArray[3] = 7.24;
            WaitArray[4] = 1.80;
            WaitArray[5] = -8;
            WaitArray[6] = -5.70;
            WaitArray[7] = -11.26;
            WaitArray[8] = -17.12;
            WaitArray[9] = -22.88;
            WaitArray[10] = -27.92;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startVal, stopVal);
            CollectionAssert.AreEqual(WaitArray, res);

        }
    }
}
