using System;

namespace _4._Preço {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Preço e Quantidade");

            Console.WriteLine();
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            double preco = 0;

            if (codigo == 1) {
                preco = 4.00 * (double)quantidade;
                Console.WriteLine($"Cachorro quente R$4,00 = Total R$ {preco}");
            }
            else if (codigo == 2) {
                preco = 4.5 * (double)quantidade;
                Console.WriteLine($"X-Salada R$4,50 = Total R${preco}");
            }
            else if (codigo == 3) {
                preco = 5 * (double)quantidade;
                Console.WriteLine($"X-Bacon R$5,00 = Total R${preco}");
            }
            else if (codigo == 4) {
                preco = 2 * (double)quantidade;
                Console.WriteLine($"Torrada R$2,00 = Total R$ {preco}");
            }
            else if (codigo == 5) {
                preco = 1.5 * (double)quantidade;
                Console.WriteLine($"Refrigerante R$1,50 = Total R${preco}");
            }
        }
    }
}
