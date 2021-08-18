using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo01
{
    class SelectionSort
    {
        static void Sort(int[] arr)
        {
            for(int i =0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; i++)
                {
                    if (arr[j] < arr[min])
                    {
                        int tmp = arr[min];
                        arr[min] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }
    }
}
