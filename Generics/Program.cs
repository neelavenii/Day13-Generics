using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics");
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intArr = new int[size];
            for(int i = 0; i < size; i++)
            {
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            double[] doubleArr = { 10.23, 56.34, 67.23 };
            char[] charArr = { 'H', 'E', 'L', 'L', 'O' };
           Uc1PrintArray.PrintArrayElements(intArr);
            Uc1PrintArray.PrintArrayElements(doubleArr);
            Uc1PrintArray.PrintArrayElements(charArr);
            Console.ReadLine();

        }
    }
}
