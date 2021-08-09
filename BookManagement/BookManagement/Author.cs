using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement
{
    class Author
    {
        public string fullname { get; private set; }
        public int age  { get; private set; }
        public string nickName { get; private set; }
        public string address { get; private set; }

        public Author() { }

        public Author(string fullname, int age, string nickName, string address)
        {
            this.fullname = fullname;
            this.age = age;
            this.nickName = nickName;
            this.address = address;
        }

        public void input(List<Author> author) 
        {
            Console.WriteLine("Nhap ten tac gia: ");
            fullname = Console.ReadLine();
            Console.WriteLine("Nhap tuoi tac gia: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap but danh tac gia: ");
            while (true)
            {
                nickName = Console.ReadLine();
                if (!checkNickName(author,nickName))
                {
                    break;
                }
                Console.WriteLine("trung but danh, vui long nhap lai: ");
            }

            Console.WriteLine("Nhap dia chi tac gia: ");
            address = Console.ReadLine();
        }

        public bool checkNickName(List<Author> author,string nickName)
        {
            for (int i = 0; i < author.Count; i ++)
            {
                if (author[i].nickName.Equals(nickName))
                {
                    return true;
                }
            }
                return false;
        }

        public void display()
        {
            Console.WriteLine("Thong tin tac gia(fullname: {0} , age : {1} , nickName : {2} , address : {3})"
                , fullname, age, nickName, address);
        }
    }
}
