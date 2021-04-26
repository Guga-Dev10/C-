using Sobreposição.Entities;
using System;

namespace Sobreposição
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sobreposição é a implementação de um método de uma superclasse em uma subclasse

            /*      Para que um método comum (não abstrato) possa ser sobreposto, deve ser 
             *  incluído nele o prefixo 'virtual'.
             *  
             *      Ao sobrescrever um método devemos incluir nele o prefixo 'override'.
             */

            Account acc1 = new Account(101, "Gustavo", 1500);
            Account acc2 = new SavingsAccount(101, "Gustavo", 1500, 0.01);

            acc1.Withdraw(100); // Saque com taxa de 5.0
            acc2.Withdraw(100); // Saque sem taxa

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine();

            Account acc3 = new Account(101, "Gustavo", 1500);
            Account acc4 = new SavingsAccount(101, "Gustavo", 1500, 0.01);

            acc3.Withdraw2(100); // Sobreposição usando base
            acc4.Withdraw2(100);

            Console.WriteLine(acc3.Balance); // Saque com taxa de 5.0
            Console.WriteLine(acc4.Balance); // Saque com sobre posição + 2.0;
        }
    }
}
