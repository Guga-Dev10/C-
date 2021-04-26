using System;
using Herança.Entities;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classe + Subclasse + Protected
            // A herança reutiliza dados e métodos de outra classe adicionando apenas os
            // dados e métodos da classe herdeira (subclasse)

            Account account = new Account(152, "Gustavo", 1800);
            double amount = 100;
            account.WithDraw(amount);   

            Console.WriteLine(account.Balance);

            account.Deposit(amount);

            Console.WriteLine(account.Balance);

            BusinessAccount ba = new BusinessAccount(120, "Renan", 1500, 1000);

            Console.WriteLine(ba.Balance);

            amount = 1000;
            ba.Loan(amount);
            Console.WriteLine(ba.Balance);
        }
    }
}
