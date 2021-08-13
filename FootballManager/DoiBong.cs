using System;
using System.Collections.Generic;
using System.Text;

namespace FootballManager
{
    class DoiBong
    {
        public string Id {get; set; }
        public string Name { get; set; }
        public string HLVName { get; set; }

        public void input()
        {
            Console.WriteLine("Nhap ma doi: ");
            Id = Console.ReadLine();
            edit();
        }

        public void edit()
        {
            Console.WriteLine("Nhap ten doi: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap ten HLV: ");
            HLVName = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Ma doi : {0}", Id);
            Console.WriteLine("Ten doi : {0}", Name);
            Console.WriteLine("Ten HLV : {0}", HLVName);
        }
    }
}
