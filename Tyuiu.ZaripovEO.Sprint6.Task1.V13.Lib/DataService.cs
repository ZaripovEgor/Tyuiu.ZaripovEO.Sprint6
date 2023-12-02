using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaripovEO.Sprint6.Task1.V13.Lib
{
    public class DataService : ISprint6Task1V13
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
                
                y = Math.Round((3 * Math.Cos(x)) / (4 * x -0.5) + Math.Sin(x) - 5 * x - 2 , 2);
                valueArray[count] = y;
                count++;
                
            }
            return valueArray;
        }
    }
}
