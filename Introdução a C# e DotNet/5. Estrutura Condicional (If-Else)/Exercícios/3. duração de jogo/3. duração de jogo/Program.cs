using System;

namespace _3._duração_de_jogo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("duração de um Jogo");

            Console.WriteLine();
            Console.WriteLine("Digite a hora inicial e a hora final na mesma linha:");
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]); // Hora inicial
            int b = int.Parse(vet[1]); // Hora final

            int duracao = 0;

            if (a < b) {
                duracao = b - a;
            }
            else {
                duracao = (24 - a) + b;
            }

            Console.WriteLine($"Duração do jogo foi de: {duracao} horas");
        }
    }
}
