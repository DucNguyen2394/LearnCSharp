using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionManage
{
    class MenuQuestion
    {
        static List<Question> questions = new List<Question>();
        static int choose;
        public void MenuQuestions()
        {
            do
            {
                Menu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        DisplayQuestion();
                        break;
                    case 2:
                        Edit();
                        break;
                    case 3:
                        Create();
                        break;
                    case 4:

                        break;
                    default:
                        Console.WriteLine("Chon lai");
                        break;
                }
            } while (choose != 4);
        }

        public static void Menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("======Quản lý Câu hỏi/Trả lời=======");
            Console.WriteLine("1. Xem danh sách");
            Console.WriteLine("2. Cập nhật câu hỏi");
            Console.WriteLine("3. Tạo mới một câu hỏi");
            Console.WriteLine("0. Trờ về menu chính.");
        }

        static void Create()
        {
            String choose;
            while (true)
            {
                Question question = new Question();
                question.Input();

                questions.Add(question);

                Console.WriteLine("Ban co muon nhap tiep khong? Y/N");
                choose = Console.ReadLine();
                if (choose.Equals("N")) break;
            }
        }

        static void Edit()
        {
            Console.WriteLine("Nhap ma cau hoi: ");
            string id = Console.ReadLine();
            foreach(var item in questions)
            {
                if (item.MaCauHoi.Equals(id))
                {
                    item.Edit();
                }
                questions.Add(item);
            }
        }

        static void DisplayQuestion()
        {
            foreach (var item in questions)
            {
                item.Display();
            }
        }

    }
}
 