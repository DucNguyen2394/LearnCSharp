using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = ReadDouble();
                Console.WriteLine(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
   
        static double ReadDouble()
        {
            try
            {
                string input = Console.ReadLine();
                var number = Convert.ToDouble(input);
                return number;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
