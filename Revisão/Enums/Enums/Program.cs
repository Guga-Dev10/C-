using Enums.Entities;
using Enums.Entities.Enums;
using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    Enumeração = é um tipo especial que serve para especificar de forma literal
            um conjunto de constantes relacionadas.
                    Possui uma melhor semântica e possui uma representação melhor, deixando o código
            de uma forma mais legível.
             */

            Order order = new Order
            {
                Id = 1996,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Convertendo Enum para String
            Console.WriteLine();
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            Console.WriteLine();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
