using System;

namespace MaxValue
{
    class Program
    {

        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = (a > b & a > c) ? a : (b > c ? b : c);

            Console.WriteLine(max);
        }
    }
}
