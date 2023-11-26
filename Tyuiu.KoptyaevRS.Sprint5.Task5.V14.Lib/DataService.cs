using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KoptyaevRS.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            double min = -100000;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if ((Convert.ToDouble(line) % 3 == 0))
                    {
                        if (min < Convert.ToDouble(line))
                        {
                            min = Convert.ToDouble(line);
                        }
                    }
                }
            }
            for (int i = 1; i <= min; i++)
            {
                res = res * i;
            }
            return res;
        }
    }
}
