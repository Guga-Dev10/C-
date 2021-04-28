using System;
using System.Globalization;
using AccountBank.Entities;
using AccountBank.Entities.Exception;

namespace AccountBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                Console.WriteLine("Enter account data");
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
                Console.WriteLine(account);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CI);
                account.WithDraw(amount);

                Console.WriteLine("Update account: \n" + account);
            }
            catch (DomainException D)
            {
                Console.WriteLine(D.Message);
            }
        }
    }
}