using System;
using System.Globalization;
using BankAccount.Entities;
using BankAccount.Entities.Exceptions;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter Account Data");
            Console.WriteLine();

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string name = Console.ReadLine();
            Console.Write("Balance: ");
            double balance = double.Parse(Console.ReadLine(), CI);
            Console.Write("WithDraw Limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CI);

            Account account = new Account(number, name, balance, withDrawLimit);
            Console.WriteLine();

            Console.Write("Enter the Withdraw amount: ");
            double amount = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine();

            try
            {
                account.WithDraw(amount);
                Console.WriteLine("Trasaction sucessful! \n" + "New Balance: $" + account.Balance.ToString("F2", CI));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
