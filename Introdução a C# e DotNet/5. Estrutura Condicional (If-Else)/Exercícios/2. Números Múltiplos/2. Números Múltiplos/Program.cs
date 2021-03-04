using System;

namespace _2._Números_Múltiplos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Múltiplos");

            Console.WriteLine();
            Console.WriteLine("Digite dois números inteiros na mesma linha: ");

            string[] vetor = Console.ReadLine().Split(' ');
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            if (x % y == 0 || y % x == 0) {
                Console.WriteLine("Números múltiplos!");
            }
            else {
                Console.WriteLine("Não são múltiplos!");
            }
        }
    }
}
