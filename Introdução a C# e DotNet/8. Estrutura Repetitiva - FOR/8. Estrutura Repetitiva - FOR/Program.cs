using System;

namespace _8._Estrutura_Repetitiva___FOR {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("For");

            Console.WriteLine();
            Console.Write("Digite a quantidade de repetições: ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++) {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
