using System;

namespace _1.Impares {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Impares");

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                    soma += i;
                }
            }
            Console.WriteLine("SOMA = {0}", soma);
        }
    }
}
