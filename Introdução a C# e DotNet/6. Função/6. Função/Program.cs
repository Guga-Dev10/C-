using System;

namespace _6._Função {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Função");

            // Fazer um programa que leia três números inteiros e apresentar o maior deles.

            Console.WriteLine();
            Console.WriteLine("Digite três números inteiros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int resultado = Maior(a, b, c);

            Console.WriteLine("Maior: " + resultado);

            Console.WriteLine();
            Console.WriteLine("Digite mais três números inteiros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado2 = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado2);
        }

        static int Maior(int n1, int n2, int n3) {
            int M;
            if (n1 > n2 && n1 > n3) {
                M = n1;
            }
            else if (n2 > n3) {
                M = n2;
            }
            else {
                M = n3;
            }
            return M;
        }
    }
}
