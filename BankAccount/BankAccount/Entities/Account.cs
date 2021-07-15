using System;

namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public double Withdraw { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit, double withdraw)
        {
            if(withdraw > withdrawLimit)
            {
                throw new InsufficientExecutionStackException("Withdraw error: The amount exceeds withdraw limit");
            }
            if (withdraw > balance)
            {
                throw new ArgumentException("Withdraw error: Not enough balance");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
            Withdraw = withdraw;
        }
    }
}
