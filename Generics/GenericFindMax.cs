using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class GenericFindMax<T> where T : IComparable
    {
        public T first,second, third;
        public  GenericFindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T FindMaxValue(T first, T second, T third)
        {
            //0,1,-1
            int res = first.CompareTo(second);
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First is having max value");
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
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
                return default;
            }

        }
        public void TestMaximum()
        {
           T maxValue= FindMaxValue(first, second, third);
            Console.WriteLine("MaxValue:" + maxValue);
        }
    }
    }

