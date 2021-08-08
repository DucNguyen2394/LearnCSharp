using System;

namespace TronExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int totalSalary = 0;

                Console.WriteLine("Nhap so goi hang ban duoc: ");
                int n = int.Parse(Console.ReadLine());
                totalSalary = 50 * n + 75;

                Console.WriteLine("Co lam ca dem hay khong: Y/N");
                String choose = Console.ReadLine();

                if (choose.ToLower().Contains("y"))
                {
                    totalSalary = (110 * totalSalary) / 100; 
                }

                Console.WriteLine("tong luong = " + totalSalary);

                Console.WriteLine("Ban co muon thoat hay khong: Y/N ");
                String c = Console.ReadLine();
                if (c.ToLower().Contains("y"))
                {
                    break;
                }
            } while (true);
        }
    }
}
