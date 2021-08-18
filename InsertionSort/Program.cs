using System;

namespace InsertionSort
{
    class Program
    {
       static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j]; 
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void Main(String[] args)
        {
            int[] arr = {78,5,334,5,7,6,3,23,6,675,2,76,3,234};
            
            Sort(arr);
            Console.WriteLine("Mang da xap sep: ");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
