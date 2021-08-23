using System;

namespace _2.Bank_Account_method
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;

            acc.Deposit(3000);

            acc.Withdraw(120);
            Console.WriteLine(acc.ToString());
        }
    }
}
