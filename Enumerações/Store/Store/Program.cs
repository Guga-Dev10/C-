using Store.Entities;
using Store.Entities.Enums;
using System;
using System.Globalization;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Exercício de fixação = Compra, produtos e status de compra
             */
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("ENTER CLIENT DATA:");
            Console.WriteLine();

            Console.Write("Name = ");
            string name = Console.ReadLine();
            Console.Write("Email = ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (dd/MM/yyyy) = ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();
            Console.WriteLine("Enter order's data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Produtc name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CI);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);
        }
    }
}
