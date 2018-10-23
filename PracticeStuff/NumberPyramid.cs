using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class NumberPyramid
    {
        public void PyramidOfNumbers()
        {
            // Make a number pyramid
            int pyra = 0;

            Console.WriteLine("Please enter a number to make your number pyramid");
            pyra = int.Parse(Console.ReadLine());

            for(int i = 1; i <= pyra; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
