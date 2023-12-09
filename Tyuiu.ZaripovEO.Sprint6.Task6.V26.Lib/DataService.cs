using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ZaripovEO.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public int len = 0;
        public string CollectTextFromFile(string path)
        {
            string strResult;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != "")
                {
                    len++;
                }
            }

            using (StreamReader reader = new StreamReader(path))
            {
                int index = 0;
                string[] res = new string[len];
                string line;
                while ((line = reader.ReadLine()) != "")
                {
                    string[] words = line.Split(' ');
                    res[index] = words[words.Length - 1];
                    index++;
                }
                strResult = string.Join(" ", res);
            }
            return strResult;
        }
    }
}
