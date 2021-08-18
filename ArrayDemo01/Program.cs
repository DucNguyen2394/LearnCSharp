using System;
using static System.Console;
using static System.Convert;

namespace ArrayDemo01
{
    class Program
    {
        static void Main(string[] args)
        {

            Write("Nhap n :");
            int n = int.Parse(ReadLine());
            int[] array = new int[1000];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(ReadLine());
            }
            int max = array[0];
            int secmax = array[0];
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];

                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] > secmax && array[i] < max)
                {
                    secmax = array[i];
                }
            }
            Console.WriteLine("\tMang sap xep theo chieu tang dan la (BBS) :");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int higher = array[i];
                    if (array[i] > array[j])
                    {
                        array[i] = array[j];
                        array[j] = higher;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Write("{0} \t", array[i]);
            }

            Console.WriteLine("\n\tMang sap xep theo chieu tang dan la (SS) :");
            int indexMin;
            for (int i = 0; i < n - 1; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[indexMin])
                    {
                        indexMin = j;
                    }
                }
                if (indexMin != i)
                {
                    int temp = array[indexMin];
                    array[indexMin] = array[i];
                    array[i] = temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Write("{0} \t", array[i]);
            }

            WriteLine("\nGia tri max la : {0}", max);
            WriteLine("\nGia tri phan tu lon thu 2 la : {0}", secmax);
            ReadLine();
        }
    }
}

