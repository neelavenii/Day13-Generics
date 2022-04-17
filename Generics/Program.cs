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
            Console.WriteLine("1:Print Array elements without Generics\n2:Print Array elements without Generics\n3:Generic class for printing Array\n4:FindMax\n5:FloatMaximum\n6:StringMaximum\n7:FindMaxUsing Generics");
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
                case 4:
                    int p = 10, q = 1, r = 56;
                    Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxValue(p, q, r), p, q, r);
                    break;
                case 5:
                    int x = 10, y = 1,  z= 56;
                    float a = 10.34f, b = 80.43f, c = 34.12f;
                   Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxValue(x, y,z), x,y,z);
                    Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxValue((int)a, (int)b, (int)c), a, b, c);

                    break;
                case 6:
                   // int x = 10, y = 1, z = 56;
                    //float a = 10.34f, b = 80.43f, c = 34.12f;
                   // string d1= "abc", d2 = "pqr", d3 = "xyz";
                    // Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxValue(x, y, z), x, y, z);
                    //Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxValue((int)a, (int)b, (int)c), a, b, c);
                  //  Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxValue((string)d1,(string)d2,(string) d3), d1, d2, d3);
                    break;
                case 7:
                    int k = 10, l = 80, m = 78;
                    new GenericFindMax<int>(k, l, m).TestMaximum();
                    break;
                default:
         
                    break;
            }
            //Console.WriteLine("Welcome To Generics");
           
            Console.ReadLine();

        }
    }
}
