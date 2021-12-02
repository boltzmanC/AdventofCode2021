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

        public static void SonarSweep()
        {
            string file = @"C:\Users\boltz\source\repos\AdventofCode2021\AdventofCode2021\input_depths.txt";

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

            //output
            Console.WriteLine("Sonar sweep part one:");
            Console.WriteLine($"Sonar sweep count of depth increases: {increasecount}");
            Console.ReadKey();
        }

        public static void SonarSweepPartTwo()
        {
            string file = @"C:\Users\boltz\source\repos\AdventofCode2021\AdventofCode2021\input_depths.txt";

            List<int> numbers = new List<int>();

            using (StreamReader newfile = new StreamReader(file))
            {
                string line = string.Empty;

                while ((line = newfile.ReadLine()) != null)
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


            // 199  A
            // 200  A B
            // 208  A B C
            // 210    B C D
            // 200  E   C D
            // 207  E F   D
            // 240  E F G
            // 269    F G H
            // 260      G H
            // 263        H

            int increasecount = 0;

            int grouponesum = 0;
            int grouptwosum = 0;
            

            for (int i = 3; i < numbers.Count(); i++)
            {
                grouponesum = numbers[i - 3] + numbers[i - 2] + numbers[i - 1];
                grouptwosum = numbers[i - 2] + numbers[i - 1] + numbers[i];

                if (grouptwosum > grouponesum)
                {
                    increasecount++;
                }

            }

            //output
            Console.WriteLine();
            Console.WriteLine("Sonar sweep part two:");
            Console.WriteLine($"Three count of depth increases: {increasecount}");
            Console.ReadKey();

        }
    }
}
