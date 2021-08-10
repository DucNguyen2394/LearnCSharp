using System;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVal;
            double dblVal;
            string strVal;
            intVal = 10;
            dblVal = 3.142;
            strVal = "Fpt Aptech";
            Console.WriteLine("{0} is an integer value", intVal);
            Console.WriteLine("{0} is an double value", dblVal);
            Console.WriteLine("{0} is an string", strVal);
            Console.ReadLine();

            int valueVal = 5;
            Test(valueVal);
            Console.WriteLine("The value of the variable is {0}", valueVal);
            Console.ReadLine();
        }

        static void Test(int valueVal)
        {
            int temp = 5;
            valueVal = temp * 2;

        }
    }
}
