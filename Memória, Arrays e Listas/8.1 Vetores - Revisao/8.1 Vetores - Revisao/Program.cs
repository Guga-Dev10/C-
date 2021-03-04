using System;

namespace _8._1_Vetores___Revisao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            Console.WriteLine();
            Console.WriteLine("Insira os dados dos produtos: ");

            double sum = 0;

            for (int i = 0; i < n; i++) {
                Console.Write("Nome = ");
                string name = Console.ReadLine();
                Console.Write("Preço = ");
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };

                sum = sum + price;
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Dados do Vetor: ");

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Name = " + vect[i].Name + "\n" + "Price = " + vect[i].Price);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Sum and Average's prices:");
            double average = sum / n;
            Console.WriteLine("Sum = " + sum + "\n" + "Average = " + average);
        }
    }
}
