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

            while (l <= r)
            {
                while (a[l] < key) l++;

                while (a[r] > key) r--;
                
                if(l <= r)
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
            int[] arr = { 2, 12, 933, 51, 8, 5, 3, 1, 6 ,553,23,213,67,87,2,1,34};

            
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
