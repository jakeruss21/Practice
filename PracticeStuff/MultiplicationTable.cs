using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class MultiplicationTable
    {
        public void TableOfMultiples()
        {
            int columns = 0;
            int rows = 0;
            int product = 0;

            Console.WriteLine("Please enter the number of desired columns");
            columns = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of desired rows");
            rows = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rows; i++)
            {
                if (i == 1)
                {
                    for (int k = 1; k <= columns; k++)
                    {
                        Console.Write($"\t{k}");
                    }
                    Console.WriteLine();
                }
                Console.Write($"{i}\t");

                for (int j = 1; j <= columns && j <= i; j++)
                {
                    product = i * j;
                    Console.Write($"{product}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
