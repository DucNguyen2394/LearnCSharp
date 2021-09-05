using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionManage
{
    class Program
    {
        static List<Question> questions = new List<Question>();
        static int choose;
        static void Main(string[] args)
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

        static void Menu()
        {
            Console.WriteLine("1. Quan ly cau hoi/ tra loi ");
            Console.WriteLine("2. Quan ly de thi ");
            Console.WriteLine("3. Thoat");
        }

    }
}
