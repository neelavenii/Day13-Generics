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
            
            int[] intArr = { 10, 56, 23 };
            double[] doubleArr = { 10.23, 56.34, 67.23 };
            char[] charArr = { 'H', 'E', 'L', 'L', 'O' };
            Console.WriteLine("Please choose program number to Execute");
            Console.WriteLine("1:Print Array elements without Generics\n2:Print Array elements without Generics\n3:Generic class for printing Array\n");
                int input = Convert.ToInt32(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter size of array");
                    int size = Convert.ToInt32(Console.ReadLine());
                     intArr = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        intArr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    
                    Uc1PrintArray.PrintArrayElements(intArr);
                    Uc1PrintArray.PrintArrayElements(doubleArr);
                    Uc1PrintArray.PrintArrayElements(charArr);
                    break;
                    case 2:
                    Uc2GenericPrintArray.PrintArrayElements<int>(intArr);
                    Uc2GenericPrintArray.PrintArrayElements<double>(doubleArr);
                    Uc2GenericPrintArray.PrintArrayElements<char>(charArr);
                    break;
                case 3:
                    new GenericClassForArray<int>(intArr).PrintArrayElements();
                    new GenericClassForArray<double>(doubleArr).PrintArrayElements();
                    new GenericClassForArray<char>(charArr).PrintArrayElements();
                    // intObj.PrintArrayElements();
                    break;
                default:
         
                    break;
            }
            //Console.WriteLine("Welcome To Generics");
           
            Console.ReadLine();

        }
    }
}
