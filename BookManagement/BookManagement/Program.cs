using System;
using System.Collections.Generic;

namespace BookManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> author = new List<Author>();
            List<Book> book = new List<Book>();
            int choose;
            do
            {
                showMenu();
                Console.WriteLine("Ban chon: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        inputBook(book,author);
                        break;
                    case 2:
                        display(book);
                        break;
                    case 3:
                        inputAuthor(author);
                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("bye ");
                        break;
                    default:
                        Console.WriteLine("chon sai vui long chon lai ");
                        break;
                }
            } while (choose != 5);
        }

        static void showMenu()
        {
            Console.WriteLine("1. Nhap thong tin sach");
            Console.WriteLine("2. Hien thi thong tin sach");
            Console.WriteLine("3. Nhap thong tin tac gia");
            Console.WriteLine("4. Tim kiem");
            Console.WriteLine("5. Thoat");
        }

        static void inputAuthor(List<Author> author)
        {
            Console.WriteLine("Nhap so tac gia can them: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Author auth = new Author();
                auth.input(author);
                author.Add(auth);
            }
        }
        static void inputBook(List<Book> book,List<Author> author)
        {
            Console.WriteLine("Nhap so sach can them: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Book book1 = new Book();
                book1.input();
                if (!checkNickName(author,book))
                {
                    Author auth = new Author();
                    auth.input(author);
                    author.Add(auth);
                }
                book.Add(book1);
            }
        }
        static bool checkNickName(List<Author> author, List<Book> book)
        {
            for (int i = 0; i < author.Count; i++)
            {
                if (author[i].nickName.Equals(book[i].nickName))
                {
                    return true;
                }
            }
            return false;
        }

        static void display(List<Book> book)
        {
            for(int i = 0; i < book.Count; i ++ )
            {
                book[i].display();
            }
        }
    
    }
}
