using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class GenericClassForArray<T>
    {
        public T[] arr;

        public GenericClassForArray(T[] arr)
        {
            this.arr= arr;
        }
        public void PrintArrayElements()
        {
            Console.WriteLine("Integer array Elements");
            foreach (var element in arr)
            {
                Console.Write(element+" ");
            }

        }
    }
}
