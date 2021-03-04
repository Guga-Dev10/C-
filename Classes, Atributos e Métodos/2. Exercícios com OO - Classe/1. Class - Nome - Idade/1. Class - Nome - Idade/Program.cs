using System;

namespace _1._Class___Nome___Idade {
    class Program {
        static void Main(string[] args) {
            Console.Write("Class - Nome - Idade");

            NomeIdade p1, p2;

            p1 = new NomeIdade();
            p2 = new NomeIdade();

            Console.WriteLine();
            Console.Write("Digite o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (p1.idade > p2.idade) {
                Console.WriteLine("A maior idade é = " + p1.idade);
            }
            else {
                Console.WriteLine("A maior idade é = " + p2.idade);
            }
        }
    }
}
