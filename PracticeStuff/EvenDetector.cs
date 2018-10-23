using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class EvenDetector
    {
        private IsOdd notEven = new IsOdd();

        public bool this [int index]
        {
            get => !notEven[index];
        }

    }
}
