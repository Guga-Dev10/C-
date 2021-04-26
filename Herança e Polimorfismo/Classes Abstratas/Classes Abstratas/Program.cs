using System;
using System.Collections.Generic;
using Classes_Abstratas.Entities;

namespace Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Gustavo", 500, 0.01));
            list.Add(new SavingsAccount(1002, "Gustavo", 500, 0.01));
            list.Add(new BusinessAccount(1003, "Gustavo", 500, 400));
            list.Add(new BusinessAccount(1004, "Gustavo", 500, 500));

            double sum = 0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total Balance = $" + sum);
            Console.WriteLine();

            // Usando operações com polimorfismo
            sum = 0;
            foreach (Account acc in list)
            {
                acc.Withdraw2(10);
                sum += acc.Balance;
            }
            foreach (Account acc in list)
            {
                Console.WriteLine(
                    "Count: "
                    + acc.Number
                    + " $"
                    + acc.Balance
                    );
            }
            Console.WriteLine("Update total balance = $" + sum);

            /*      Uma classe abstrata não permite que ela seja instanciada, bloqueando 
             *  o uso de seus recursos pelo programa principal. Somente é permitido o uso 
             *  de seus atributos e métodos pelas classes herdeiras das classes abstratas,
             *  ou seja, somente as subclasses podem herdar e utilizar os recursos das classes
             *  abstratas. Somente os atributos das subclasses podem ser instanciados, permitindo
             *  uma herança total da classe mãe.
             */
        }
    }
}
