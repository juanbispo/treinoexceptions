using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoExceptions.Models.Exceptions;

namespace TreinamentoExceptions.Models
{
    internal class Account
    {
        public int Number { get; set; }
        public string TitularName { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string titularName, double balance, double withdrawLimit)
        {
            Number = number;
            TitularName = titularName;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if ((amount - Balance) > 0)
            {
                throw new AccountException("The withdraw can't be greater than the Balance");
            }
            if (amount > WithdrawLimit)
            {
                throw new AccountException("The withdraw can't be greater than the Account Withdraw Limit ");
            }
            Balance -= amount;
        }
    }
}
