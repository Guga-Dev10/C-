using System;
using System.Globalization;
using Revision.Entities;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sales:");
            System.Console.WriteLine();

            Console.Write("Costumer's name: ");
            string name = Console.ReadLine();
            Console.Write("costumer's Age: ");
            int years =  int.Parse(Console.ReadLine());
            Console.Write("Product's price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine();

            CostumerData cs = new CostumerData(name, years, price);

            Console.WriteLine(cs);
        }
    }
}