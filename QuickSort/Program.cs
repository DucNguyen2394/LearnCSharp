using System;

namespace QuickSort
{
    class Program
    {
        static void Sort(int[] a, int l, int r)
        {
            if (l >= r) return;

            int key = a[(l + r) / 2];

            int mid = Partition(a, l, r, key);

            Sort(a, l , mid - 1);

            Sort(a, mid, r);
        }

        static int Partition(int[] a, int l, int r, int key)
        {
            int middle = (l + r) / 2;
            while (l <= r)
            {
                while (a[l] < key ) l++;

                while (a[r] > key) r--;

                if (l <= r)
                {
                    int tmp = a[l];

                    a[l] = a[r];

                    a[r] = tmp;

                    l++; r--;

                }
                
            }

            return l;
        }
        
        static void Main(String[] args)
        {
            //int[] arr = { 1,3,4,2,6,8,1};
            int[] arr = { 29, 40, 63, 54, 17,12,3,56,67,23,12,3,46,32,9 };

            Console.WriteLine("mang chua sap xep");

            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("mang da chua sap xep");
            Sort(arr, 0, arr.Length-1);

            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }

        }
    } 
}
