using System;

namespace Lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystem ss = new StudentSystem();
            while (true)
            {
                ss.parseCommond();
            }
        }
    }
}
