using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_net
{
    class Day2
    {

        public static int SolveDay2A()
        {
            string[] text = System.IO.File.ReadAllLines(@"..\..\..\..\Inputs\Day2.txt");

            int horizontal = 0;
            int depth = 0;

            for(int i = 0; i<text.Length; i++)
            {
                string[] input = text[i].Split(" ");
                string direction = input[0];
                int amount = Int32.Parse(input[1]);

                switch (direction)
                {
                    case "forward": horizontal += amount;
                        break;
                    case "down": depth += amount;
                        break;
                    case "up": depth -= amount;
                        break;
                }
            }

            return horizontal * depth;
        }

        public static int SolveDay2B()
        {
            string[] text = System.IO.File.ReadAllLines(@"..\..\..\..\Inputs\Day2.txt");

            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string[] input = text[i].Split(" ");
                string direction = input[0];
                int amount = Int32.Parse(input[1]);

                switch (direction)
                {
                    case "forward":
                        horizontal += amount;
                        if(aim != 0)
                        {
                            depth += amount * aim;
                        }
                        break;
                    case "down":
                        aim += amount;
                        break;
                    case "up":
                        aim -= amount;
                        break;
                }
            }

            return horizontal * depth;
        }
    }
}
