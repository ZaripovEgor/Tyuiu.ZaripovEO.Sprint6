using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaripovEO.Sprint6.Task4.V25.Lib
{
    public class DataService : ISprint6Task4V25

    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
