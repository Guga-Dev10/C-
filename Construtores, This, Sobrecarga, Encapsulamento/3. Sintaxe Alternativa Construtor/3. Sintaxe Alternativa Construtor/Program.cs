using System;
using System.Globalization;

namespace _3._Sintaxe_Alternativa_Construtor {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            double valor = double.Parse(Console.ReadLine(), CI);
             Console.Write("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());
            

            Preco p = new Preco(); // Sobrecarga instânciada sem parâmetros
            Preco p2 = new Preco(nome, valor); // Sobrecarga com dois parâmetros

            Preco p3 = new Preco { //Sintaxe Alternativa para instânciar um construtor com
                                   // valores preenchidos
                Nome = "Tv",
                Valor = 900,
                Quantidade = 10,
            };

            /*
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
            */
        }
    }
}
