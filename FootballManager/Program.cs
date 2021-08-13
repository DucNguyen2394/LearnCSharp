using System;
using System.Collections.Generic;

namespace FootballManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DoiBong> doibongList = new List<DoiBong>();


            int choose;
            do
            {
                ShowMenu();

                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        int choose1;
                        do
                        {
                            Menu1();
                            choose1 = int.Parse(Console.ReadLine());
                            
                        } while (choose1 != 4);
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
            Console.WriteLine("-----Chào mừng đến với V-League 2021-----");
            Console.WriteLine("1. Quản lý danh sách đội bóng.");
            Console.WriteLine("2. Quản lý lịch thi đấu.");
            Console.WriteLine("3. Quản lý kết quả thi đấu.");
            Console.WriteLine("4. Thống kê.");
            Console.WriteLine("5. Thoát.");
            Console.WriteLine("Ban chon: ");
        }

        static void Menu1()
        {
            Console.WriteLine("1. Xem danh sach doi bong");
            Console.WriteLine("2. cap nhat danh sach doi bong");
            Console.WriteLine("3. Them mot doi bong moi");
            Console.WriteLine("4. Tro ve menu chinh");
        }
    }
}
