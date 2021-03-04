using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            Console.WriteLine();

            // Conversão de String para Enum

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            // Conversão de Enum para String

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
