using System;
using System.Collections.Generic;

namespace QuestionManage
{
    class Program
    {
        static int choose;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowMenu();
        }

        static void Menu()
        {
            Console.WriteLine("============Main Menu==============");
            Console.WriteLine("1. Quan ly cau hoi/ tra loi ");
            Console.WriteLine("2. Quan ly de thi ");
            Console.WriteLine("3. Thoat");
        }

        public void ShowMenu()
        {
            MenuQuestion menuQuestion = new MenuQuestion();
            do
            {
                Menu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        menuQuestion.MenuQuestions();
                        break;
                    case 2:

                        break;
                    case 3:
                        Console.WriteLine("Bye!!! ");
                        break;
                    default:
                        Console.WriteLine("Ban chon sai vui long chon lai ");
                        break;
                }
            } while (choose != 3);
        }
    }

}

