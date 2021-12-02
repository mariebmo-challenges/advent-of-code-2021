using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_net
{
    class Day1
    {


        public static int SolveDay1A()
        {
            string[] text = System.IO.File.ReadAllLines(@"..\..\..\..\Inputs\Day1.txt");

            int previousNum = Int32.Parse(text[0]);
            int increases = 0;

            for(int i = 1; i<text.Length; i++)
            {
                int currentNum = Int32.Parse(text[i]);

                if(currentNum > previousNum)
                {
                    increases++;
                }

                previousNum = currentNum;
            }
            return increases;
        }

        public static int SolveDay1B()
        {
            string[] text = System.IO.File.ReadAllLines(@"..\..\..\..\Inputs\Day1.txt");

            int previousSum = Int32.Parse(text[0]) + Int32.Parse(text[1]) + Int32.Parse(text[2]);
            int increases = 0;

            for (int i = 1; i < text.Length-2; i++)
            {
                int currentsum = Int32.Parse(text[i]) + Int32.Parse(text[i+1]) + Int32.Parse(text[i+2]);

                if (currentsum > previousSum)
                {
                    increases++;
                }

                previousSum = currentsum;
            }
            return increases;
        }
    }
}
