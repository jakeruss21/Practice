using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class IndexerPractice
    {
        //Implement an "IsOdd" class that returns 'true' for odd numbers and False otherwise

        public void IndexPractice()
        {

            IsOdd oddDetect = new IsOdd();
            EvenDetector evenDetect = new EvenDetector();

            Console.WriteLine($"16 is Odd: {oddDetect[16]}");
            Console.WriteLine($"16 is Even:  {evenDetect[16]}");
        }
    }
}
