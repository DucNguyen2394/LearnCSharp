using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionManage
{
    class MenuQuestion
    {
        List<Question> questions = new List<Question>();
        static int choose;
        public void MenuQuestions()
        {
            Program program = new Program();
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
                        program.ShowMenu();
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
            Console.WriteLine("4. Trờ về menu chính.");
        }

        public void Create()
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

        public void Edit()
        {
            Console.WriteLine("Nhap ma cau hoi can sua: ");
            string Id = Console.ReadLine();
            foreach (var item in questions)
            {
                if (item.MaCauHoi.Equals(Id))
                {
                    item.Edit();
                    break;
                }
                else
                {
                    Console.WriteLine("ko tim thay cau hoi nao");
                }
            }
        }

        public void DisplayQuestion()
        {
            foreach (var item in questions)
            {
                item.Display();
            }
        }

    }
}
 