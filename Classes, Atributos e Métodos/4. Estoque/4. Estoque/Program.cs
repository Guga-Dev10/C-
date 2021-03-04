using System;
using System.Globalization;

namespace _4._Estoque {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Estoque");
            Console.WriteLine();

            CultureInfo CI = CultureInfo.InvariantCulture;

            Produtos p = new Produtos();

            Console.Write("Digite o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a quantidade do produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarQuantidade(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Produtos a serem retirados: ");
            qte = int.Parse(Console.ReadLine());
            p.DiminuirQuantidade(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
