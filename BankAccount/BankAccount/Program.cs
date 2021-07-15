using System;
using BankAccount.Entities;
using System.Globalization;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initical balance: ");
                double Balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Console.Write("Enter amount for withdraw ");
                double withdraw = double.Parse(Console.ReadLine());

                Account Account = new Account(number, holder, Balance, withdrawLimit, withdraw);

                double newBalance = Balance - withdraw;
                Console.WriteLine("New balance: " + newBalance.ToString("F2", CultureInfo.InvariantCulture));
            }

            catch (InsufficientExecutionStackException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException i)
            {
                Console.WriteLine(i.Message);
            }

        }
    }
}
