﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Uc2GenericPrintArray
    {
        /// <summary>
        /// prints the array elements making method has generic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void PrintArrayElements<T>(T[] arr)
        {
            Console.WriteLine("\nArray Elements");
            foreach (var element in arr)
            {
                Console.Write(element+" ");
            }

        }
    }
}
