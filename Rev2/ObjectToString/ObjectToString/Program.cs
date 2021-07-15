using System;
using System.Globalization;
using ObjectToString.Entities;

namespace ObjectToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando ToString em uma classe

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Insira o dados do produto:\n");

            Console.Write("\nInsira o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Insira o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Insira a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("\n" + p);

            Console.Write("\nDeseja adicionar ou diminuir a quantidade de produtos no estoque(s/n)? ");
            string resp = Console.ReadLine();

            if (resp == "S" || resp == "s" || resp == "sim" || resp == "Sim")
            {
                Console.Write("Deseja aumentar ou diminuir a quatidade de estoque (a/d)? ");
                string resp2 = Console.ReadLine();
                
                if (resp2 == "a" || resp2 == "A" || resp2 == "aumentar" || resp2 == "Aumentar")
                {
                    Console.Write("\nDigite a quantidade a ser acrescentada ao estoque: ");
                    int qte = int.Parse(Console.ReadLine());

                    p.AumentarQuantidade(qte);
                } 

                else if (resp2 == "d" || resp2 == "D" || resp2 == "diminuir" || resp2 == "Diminuir")
                {
                    Console.Write("\nDigite a quantidade a ser retirada do estoque: ");
                    int qte = int.Parse(Console.ReadLine());

                    p.DiminuirQuantidade(qte);
                }
            }

            Console.WriteLine("\n" + p);
        }
    }
}
