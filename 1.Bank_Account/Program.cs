using System;
using System.Collections.Generic;

namespace _1.Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> account = new Dictionary<int, BankAccount>();
            BankAccount acc = new BankAccount();

            Console.WriteLine("Enter command: ");
            String[] commands = Console.ReadLine().Split(new String[] {" "},StringSplitOptions.None);

            while (commands[0]!= "stop")
            {
                if (commands[0] == ("create"))
                {
                    acc.create(commands,account);
                }
                else if(commands[0] == ("print"))
                {
                    Console.WriteLine("helo");
                }

                commands = Console.ReadLine().Split(new String[] { " " }, StringSplitOptions.None);
            }
        }
    }
}
