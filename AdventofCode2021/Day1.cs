using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventofCode2021
{
    public class Day1
    {
        // count the number of times a depth measurement increases from the previous measurement.

        public static void DepthCounter()
        {
            string file = @"C:\Users\boltz\source\repos\AdventofCode2021\input.txt";

            List<int> numbers = new List<int>();

            using (StreamReader newfile = new StreamReader(file))
            {
                string line = string.Empty;

                while((line = newfile.ReadLine()) != null)
                {
                    int newnumber = 0;
                    bool numtest = Int32.TryParse(line.Trim(), out newnumber);
                    
                    if (numtest == true)
                    {
                        numbers.Add(newnumber);
                    }
                    else
                    {
                        Console.WriteLine($"Not a number: {line}");
                    }
                }
            }

            int increasecount = 0;

            for (int i = 1; i < numbers.Count(); i++)
            {
                if (numbers[i] > numbers[i-1])
                {
                    increasecount ++;
                }
            }

            Console.WriteLine($"Count of Increases: {increasecount}");
            Console.ReadKey();
        }

        public static void SonarSweep()
        {




        }
    }
}
