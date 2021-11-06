using System;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Estoque estoque = new Estoque(nome, preco, quantidade);

            Console.Write("\nDeseja alterar a quantidade de produtos em estoque? (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            while (resp != 'n')
            {
                Console.Write("\nDeseja adiconar ou remover produtos (a/r)? ");
                char resp2 = char.Parse(Console.ReadLine());

                if (resp2 == 'a')
                {
                    Console.Write("\nQuantos produtos serão adicionados? ");
                    int qte = int.Parse(Console.ReadLine());

                    estoque.AdicionarProdutos(qte);
                }

                else if (resp2 == 'r')
                {
                    Console.Write("\nQuantos produtos serão removidos? ");
                    int qte = int.Parse(Console.ReadLine());

                    estoque.RemoverProdutos(qte);
                }
                else
                {
                    Console.WriteLine("\nRESPOSTA INCORRETA!!");
                }

                Console.WriteLine();
                Console.WriteLine(estoque);
                Console.Write("\nDeseja alterar a quantidade de produtos em estoque? (s/n)? ");
                resp = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nFim da execução!!");
        }
    }
}
