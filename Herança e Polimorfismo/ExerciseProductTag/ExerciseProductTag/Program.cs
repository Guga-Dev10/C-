using System;
using System.Globalization;
using System.Collections.Generic;
using ExerciseProductTag.Entites;

namespace ExerciseProductTag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the #{i} product data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name = ");
                string name = Console.ReadLine();
                Console.Write("Price = ");
                double price = double.Parse(Console.ReadLine(), CI);

                if (ch == 'i')
                {
                    Console.Write("Custom Fee = ");
                    double customFee = double.Parse(Console.ReadLine(), CI);
                    products.Add(new ImportedProduct(name, price, customFee));
                    Console.WriteLine();
                }
                else if(ch == 'u')
                {
                    Console.Write("Manufactured Date (MM/dd/yyyy) = ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufacturedDate));
                    Console.WriteLine();
                }
                else
                {
                    products.Add(new Product(name, price));
                    Console.WriteLine();
                }
            }
            Console.WriteLine("PRICE TAG");
            Console.WriteLine();

            foreach(Product product in products)
            {
                Console.WriteLine(product.ProductTag());
            }
        }
    }
}