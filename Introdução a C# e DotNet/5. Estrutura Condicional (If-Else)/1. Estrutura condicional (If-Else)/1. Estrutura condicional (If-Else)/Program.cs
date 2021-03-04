using System;

namespace _1._Estrutura_condicional__If_Else_ {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Estrutura condicional!");

            Console.WriteLine("Digite a hora: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 0 && x < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (x < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else if (x < 24) {
                Console.WriteLine("Boa noite!");
            }
            else {
                Console.WriteLine("Hora inválida!!");
            }

            Console.WriteLine();
            Console.WriteLine("Digite um número inteiro: ");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0) {
                Console.WriteLine($"{y} número par!");
            }
            else {
                Console.WriteLine($"{y} número impar!");
            }
        }
    }
}
