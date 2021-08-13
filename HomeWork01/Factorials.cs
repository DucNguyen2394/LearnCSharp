using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork01
{
    class Factorials
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so vao day: ");
            int n = int.Parse(Console.ReadLine());
            int answer = 1;
            for (int i = 1; i <= n; i++)
            {
                
                answer *= i;
            }
            Console.Write(answer);
        }
    }
}
