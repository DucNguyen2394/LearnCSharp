using System;

namespace MaxValue
{
    class Program
    {
        static int max(int x, int y)
        {
            if (x > y) return x;return y;
        }


        static void Main(String[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("so lon nhat la: {0}", max(max(max(a,e),max(b,f)),max(c,d)));

            int maxx = (a > b && a > c) ? a : (b > c ? b : c);

            Console.WriteLine(maxx);
        }
    }
}
