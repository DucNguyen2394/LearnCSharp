using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionManage
{
    class Question
    {
        string[] dapAn = new string[4];
        string maCauHoi;
        string cauHoi;

        string maDanhMuc { get; set; }
        public string MaCauHoi { get; set; }
        public string CauHoi { get; set; }
        float diem { get; set; }
        public Question() { }
        public Question(string maDanhMuc, string maCauHoi, string cauHoi, float diem, string[] dapAn)
        {
            this.maDanhMuc = maDanhMuc;
            this.maCauHoi = maCauHoi;
            this.cauHoi = cauHoi;
            this.diem = diem;
            this.dapAn = dapAn;
        }
        public void Input()
        {
            Console.WriteLine("Nhap ma danh muc: ");
            maDanhMuc = Console.ReadLine();
            Console.WriteLine("Nhap ma cau hoi: ");
            maCauHoi = Console.ReadLine();
            Console.WriteLine("Nhap cau hoi: ");
            cauHoi = Console.ReadLine();
            Console.WriteLine("Nhap diem: ");
            diem = float.Parse(Console.ReadLine());
            
            for(int i = 0; i < dapAn.Length; i++)
            {
                Console.WriteLine("Nhap dap an {0}: ", i);
                dapAn[i] = Console.ReadLine();

            }
        }

        public void Display()
        {
            Console.WriteLine("Ma danh muc: {0}", maDanhMuc);
            Console.WriteLine("Ma Cau hoi: {0}", maCauHoi);
            Console.WriteLine("Ten cau hoi: {0}", cauHoi);
            Console.WriteLine("Diem: {0}", diem);
            for (int i = 0; i < dapAn.Length; i++)
            {
                Console.WriteLine("Dáp Án: {0}", dapAn[i]);
            }
        }

        public void Edit()
        {
            Console.WriteLine("Nhap cau hoi: ");
            cauHoi = Console.ReadLine();
            Console.WriteLine("Nhap diem: ");
            diem = float.Parse(Console.ReadLine());

            for (int i = 0; i < dapAn.Length; i++)
            {
                Console.WriteLine("Nhap dap an {0}: ");
                dapAn[i] = Console.ReadLine();
            }
        }
    }
}
