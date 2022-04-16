using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Uc1PrintArray
    {
        public static void PrintArrayElements(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }

        }
        public static void PrintArrayElements(double[] arr)
        {
          

        }
        public static void PrintArrayElements(char[] arr)
        {
            foreach (char element in arr)
            {
                Console.WriteLine(element);
            }

        }
    }
}
