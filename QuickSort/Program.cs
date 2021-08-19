using System;

namespace QuickSort
{
    class Program
    {
        static void Sort(int[] arr, int l, int r)
        {
            if (l >= r) return;
            int key = arr[(l + r) / 2];

            int mid = Partition(arr, l, r, key);

            Sort(arr, l, mid - 1);

            Sort(arr, mid, r);
        }

        static int Partition(int[] arr, int l, int r, int key)
        {
            while (l <= r)
            {
                while (arr[l] < key) l++;

                while (arr[r] > key) r--;

                if(l <= r)
                {
                    int tmp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = tmp;
                    l++;r--;
                }

            }

            return l;
        }

        static void Main(String[] args)
        {
            int[] arr = {54,2,2,6,6,3,123,6,78,54,12,5,78,34,67,98,4,123,45,78,23,987,45,12,34,677,6,23,76,87,99,23,12};
            Console.WriteLine("Mang chua sap xep: ");

            foreach(var a in arr)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("Mang da sap xep: ");

            Sort(arr, 0, arr.Length - 1);

            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
