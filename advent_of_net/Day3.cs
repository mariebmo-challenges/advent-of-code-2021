using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_net {
    class Day3 {

        public static void SolveDay3A() {
            string[] text = System.IO.File.ReadAllLines( @"..\..\..\..\Inputs\Day3.txt" );

            string gamma = "";
            string epsilon = "";

            for (int i = 0; i < text[0].Length; i++) {
                
                int one = 0;
                int zero = 0;

                for (int j=0; j<text.Length; j++) {
                    if(text[j][i] == '1') {
                        one++;
                    } else {
                        zero++;
                    }
                }

                if(one > zero) {
                    gamma += '1';
                    epsilon += '0';
                } else {
                    gamma += '0';
                    epsilon += '1';
                }
            }

            Console.WriteLine( gamma );
            Console.WriteLine( epsilon );
        }

    }
}
