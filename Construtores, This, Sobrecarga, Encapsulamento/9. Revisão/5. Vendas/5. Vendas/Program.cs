using System;
using System.Globalization;

namespace _5._Vendas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Nome do Produto = ");
            string nomeproduto = Console.ReadLine();
            Console.Write("Quantidade = ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Preço = ");
            double preco = double.Parse(Console.ReadLine(), CI);

           /* Produto p = new Produto(nomeproduto, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Adicionar Produtos = ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarQuantidade(qte);

             Console.WriteLine();
             Console.WriteLine("Dados Atualizados = " + p);

            Console.WriteLine();
            Console.Write("Retirar Produtos = ");
            qte = int.Parse(Console.ReadLine());
            p.RetirarQuantidade(qte);

             Console.WriteLine();
             Console.WriteLine("Dados Atualizados = " + p);
           */

            Console.WriteLine();
            Console.Write("Nome do Vendedor = ");
            string vendedor = Console.ReadLine();
            Console.Write("Quantidade de vendas = ");
            int quantidadeVendas = int.Parse(Console.ReadLine());

            
            Produto p = new Produto(nomeproduto, preco, quantidade, vendedor, quantidadeVendas);

            
            Console.WriteLine();
            Console.WriteLine(p);
          
            /*  Console.WriteLine("Valor Total em estoque: " + p.ValorTotalEmEstoque());
            Console.WriteLine("Vendedor = " + p2.Vendedor + ", Quantidade de Vendas = " + p2.QuantidadeDeVendas
                + ", Comissão = " + p2.ComissaoVendedor().ToString("F2", CI));
            */
        }
    }
}
