using System;

namespace MergeSort
{
    class Program
    {
        static void Merge(int[] a, int l, int r)
        {
            if (l > r) return;
            if(l == r)
            {
                int[] element = { a[l] };
            }
            int key = (l + r) / 2;

             Merge(a,l,key - 1);
             Merge(a, key, r);



        }

        static void Main(string[] args)
        {
            int[] arr = {33,456,6,2,23,65,8,5,2134,678,53,2,754,24 };

            Console.WriteLine("Mang chua sap xep");
            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Mang da sap xep");

            Merge(arr,0, arr.Length - 1);

            foreach(var a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
