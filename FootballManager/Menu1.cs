using System;
using System.Collections.Generic;
using System.Text;

namespace FootballManager
{
    class Menu1
    {
        static int choose;
        List<DoiBong> doibongList = new List<DoiBong>();
        public void Menu()
        {
            ShowMenu();
            choose = int.Parse(Console.ReadLine());
            while(choose != 4)
            {
                switch (choose)
                {
                    case 1:
                        Create();
                        
                        return;
                    case 2:
                        Edit();

                        return;
                    case 3:
                        Display();
                        
                        return;
                    case 4:
                        Console.WriteLine("Bye!!! ");
                        break;
                    default:
                        Console.WriteLine("Ban chon sai vui long chon lai ");
                        break;
                }
            } 
        }

        public void ShowMenu()
        {
            Console.WriteLine("1. Them doi bong moi");
            Console.WriteLine("2. cap nhat danh sach doi bong");
            Console.WriteLine("3. Hien thi danh sach doi bong");
            Console.WriteLine("4. Tro ve menu chinh");
            Console.WriteLine("Ban chon");
        }

        public void Create()
        {
            String choose;
            while(true)
            {
                DoiBong doiBong = new DoiBong();
                doiBong.input();

                doibongList.Add(doiBong);

                Console.WriteLine("Ban co muon nhap tiep khong? Y/N");
                choose = Console.ReadLine();
                if (choose.Equals("N")) break;
            }  
        }

        public void Edit()
        {
            Console.WriteLine("Nhap id doi bong can tim: ");
            String Id = Console.ReadLine();
            foreach(var item in doibongList)
            {
                if (item.Id.Equals(Id))
                {        
                     item.edit();
                     break;
                }
                else { 
                    Console.WriteLine("ko tim thay doi bong nao");
                }
            }
        }

        public void Display()
        {
            foreach(var item in doibongList)
            {
                item.display();
            }
        }

    }
}
