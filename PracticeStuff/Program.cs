using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            //Convert a string to a char and then compare it
            //StringtoChar();

            //Use an indexer to determine if a number is even or odd
            //IndexerPractice index = new IndexerPractice();
            //index.IndexPractice();

            //FibonacciSeqFinder fibb = new FibonacciSeqFinder();
            //fibb.FibFinder();

            NumberPyramid pyramid = new NumberPyramid();
            pyramid.PyramidOfNumbers();

        }

        public static void StringtoChar()
        {
            bool isRepeated = false;
            string toConvert;

            Console.WriteLine("Please enter a string of characters and the program will tell you if there are any repeated characters");
            toConvert = Console.ReadLine();

            char[] converted = toConvert.ToCharArray();

            //for (int i = 0; i < converted.Length; i++)
            //{
            //    Console.Write(converted[i]);
            //}
            //Console.WriteLine("");

            for (int i = 0; i < converted.Length - 1; i++)
            {
                for (int j = i + 1; j < converted.Length; j++)
                {
                    if (converted[i] == converted[j] && converted[i] != ' ')
                    {
                        isRepeated = true;                        
                    }                    
                }
            }

            if (isRepeated == true)
            {
                Console.WriteLine("The string has repeated letters");
            }
            else
            {
                Console.WriteLine("The string has no repeated letters");
            }

        }
    }
}
