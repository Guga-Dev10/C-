using System;

namespace _3._Nome___Idade {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o nome da primeira pessoa = ");
            string Nome1 = Console.ReadLine();
            Console.Write("Digite a idade da primeria pessoa = ");
            int Idade1 = int.Parse(Console.ReadLine());

            Dados Dp = new Dados(Nome1, Idade1);

            Console.WriteLine();
            Console.Write("Digite o noma da segunda pessoa = ");
            string Nome2 = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa = ");
            int Idade2 = int.Parse(Console.ReadLine());

            Dados Dp2 = new Dados(Nome2, Idade2);

            Console.WriteLine();
            if (Dp.Idade > Dp2.Idade) {
                Console.WriteLine($"{Dp.Nome} é a pessoa mais velha com {Dp.Idade} anos");
            }
            else {
                Console.WriteLine($"{Dp2.Nome} é a pessoa mais velha com {Dp2.Idade} anos");
            }
        }
    }
}
