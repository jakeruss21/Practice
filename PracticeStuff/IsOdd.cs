using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class IsOdd
    {
        //public int numbers;

        //public IsOdd(int num)
        //{
        //    numbers = num;
        //}
        
        public bool this [int index]
        {
            get
            {
                bool val = true;
                if (index % 2 == 0)
                {
                    val = false;
                }

                return val;
            }

        }
    }
}
