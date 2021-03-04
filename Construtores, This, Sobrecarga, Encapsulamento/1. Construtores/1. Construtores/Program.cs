using System;
using System.Globalization;

namespace _1._Construtores {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            double valor = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Preco p = new Preco(nome, valor, quantidade); 

            Console.WriteLine();
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Quantos produtos serão adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Quantos produtos serão retirados: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados = " + p);
        }
    }
}
