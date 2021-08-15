using System;
using System.Collections.Generic;

namespace FootballManager
{
    class Program
    {
        static int choose;
        List<DoiBong> doibongList = new List<DoiBong>();
        static void Main(string[] args)
        {

            Menu1 menu1 = new Menu1();
            do
            {
                ShowMenu();

                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        menu1.Menu();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("Bye!!! ");
                        break;
                    default:
                        Console.WriteLine("Ban chon sai vui long chon lai ");
                        break;
                }
            } while (choose != 5);
        }

        static void ShowMenu()
        {
            Console.WriteLine("-----Chao mung den voi V-leage 2021-----");
            Console.WriteLine("1. Quan ly danh sach doi bong.");
            Console.WriteLine("2. Quan ly lich thi dau.");
            Console.WriteLine("3. Quan ly ket qua thi dau.");
            Console.WriteLine("4. Thong ke.");
            Console.WriteLine("5. Thoat.");
            Console.WriteLine("Ban chon: ");
     
        }

     
    }
}
