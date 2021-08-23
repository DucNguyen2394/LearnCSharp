using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Bank_Account_method
{
    class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id { get; set; }
        public decimal Balance { get; set; }
        public void Deposit (decimal amount){ Balance += amount; }

        public void Withdraw(decimal amount) { Balance -= amount; }

        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }
    }
}
