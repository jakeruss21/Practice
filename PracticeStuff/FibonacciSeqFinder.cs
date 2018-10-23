using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class FibonacciSeqFinder
    {
        public void FibFinder()
        {
            int find = 0;

            Console.WriteLine("Enter a position in the Fibonacci sequence you would like to find:");
            find = int.Parse(Console.ReadLine());

            double[] fib = new double[find];  //Changed from an 'int' to a 'double' in case someone wants to pic a number above 47

            for(int i = 0; i < find; i++)
            {
                if(i==0)
                {
                    fib[i] = 0;
                }
                else if(i==1)
                {
                    fib[i] = 1;
                }
                else
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }
            }

            Console.WriteLine($"Element {find} in the Fibonacci sequence is: {fib[find-1]}");
        }

    }
}
