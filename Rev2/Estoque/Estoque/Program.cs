using System;
using System.Globalization;
using Estoque.Produtos;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre com os dados do produto: \n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço : $");
            double preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine(p);

            Console.Write("\nQuantos produtos serão adicionados? ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine(p);

            Console.Write("\nQuantos produtos serão retirados? ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine(p);
        }
    }
}
