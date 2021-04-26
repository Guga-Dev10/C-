using System;
using Herança.Entities;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount BSA = new BusinessAccount(1520, "Guga", 1500, 200);
            Console.WriteLine(BSA.Balance);

            double amount = 150;
            BSA.Withdraw(amount);
            Console.WriteLine("Balance with withdraw = " + BSA.Balance);
            BSA.Balance += 150; // Acessador inacessível por causa do protected

            /* O "Protected" permite que somente as classes herdeiras possam manipular os
             * valores de suas variáveis, não deixando que elas possam ser modificadas livremente
             * pelo programa principal ou por qualquer tipo de entrada de dados feita pelo 
             * programador ou pelo usuário.
             */
        }
    }
}
