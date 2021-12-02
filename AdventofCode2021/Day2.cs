using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventofCode2021
{
    public class Day2
    {
        const string file = @"C:\Users\boltz\source\repos\AdventofCode2021\AdventofCode2021\input_commands.txt";

        public static void SubmarineDive()
        {
            int x = 0;
            int y = 0;

            // answer: x * y

            string forward = "forward"; // +x
            string down = "down"; // +y
            string up = "up"; // -y

            using (StreamReader readfile = new StreamReader(file))
            {
                string line = string.Empty;

                while ((line = readfile.ReadLine()) != null)
                {

                    string[] splitline = line.Split(' ');

                    string direction = splitline[0].Trim();
                    string distancestring = splitline[1].Trim();

                    int distance;
                    bool isnumber = Int32.TryParse(distancestring, out distance);

                    if (isnumber != true)
                    {
                        Console.WriteLine($"is not a number: {distancestring}");
                        Environment.Exit(0);
                    }

                    // direction
                    if (direction == forward)
                    {
                        x += distance;
                    }
                    else if (direction == down)
                    {
                        y += distance;
                    }
                    else if(direction == up)
                    {
                        y -= distance;
                    }
                    else
                    {
                        Console.WriteLine($"not a valid direction: {direction}");
                    }
                }

            }

            //final position
            int position = x * y;

            Console.WriteLine();
            Console.WriteLine("Submarine dive part one:");
            Console.WriteLine($"final position: {position}");
            Console.ReadKey();

        }

        public static void SubmarineDivePartTwo()
        {
            
            
            using (StreamReader readfile = new StreamReader(file))
            {

            }
        }






    }
}
