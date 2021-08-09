using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement
{
    class Book
    {
        public string name { get; set; }
        public string deliveredDate { get; set; }
        public string nickName { get; set; }
        public Book() { }
        public Book(string name, string deliveredDate, string nickName) 
        {
            this.name = name;
            this.deliveredDate = deliveredDate;
            this.nickName = nickName;
        }

        public void input()
        {
            Console.WriteLine("Nhap ten sach ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap ngay xuat ban sach ");
            deliveredDate = Console.ReadLine();
            Console.WriteLine("Nhap but danh tac gia ");
            nickName = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Thong tin sach: (Ten sach {0} , ngay xuat ban {1} , but danh {2})", name, deliveredDate,nickName);
        }

    }
}
