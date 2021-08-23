using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Bank_Account
{
    class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id { get; set; }
        public decimal Balance { get; set; }

        public void create(string[] cmdArgs, Dictionary<int,BankAccount> acc) 
        {
            Console.WriteLine("enter id: ");
            int id = int.Parse(cmdArgs[1]);

            if (acc.ContainsKey(id))
            {
                Console.WriteLine("Account is exist!");
            }
            else
            {
                BankAccount account = new BankAccount();
                account.id = id;
                acc.Add(id,account);
            }
        }
        public void Deposit(decimal amount) { Balance += amount; }

        public void Withdraw(decimal amount) { Balance -= amount; }

        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }
    }
}
