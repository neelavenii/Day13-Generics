﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class FindMax
    {
        public static int FindMaxValue(int first,int second,int third)
        {
            //0,1,-1
            if(first.CompareTo(second)> 0 && first.CompareTo(third)>0)
                {
                Console.WriteLine("First is having max value");
                return first;
                }
            else if(second.CompareTo(first)>0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second is having max value");
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("Third is having max value");
                return third;
            }
            else
            {
                Console.WriteLine("may 2 or 3 variables are equal");
                return 0;
            }

        }

        
    }
}
