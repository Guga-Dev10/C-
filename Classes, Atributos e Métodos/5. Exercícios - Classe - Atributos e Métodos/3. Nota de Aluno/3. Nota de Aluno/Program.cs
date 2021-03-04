using System;

namespace _3._Nota_de_Aluno {
    class Program {
        static void Main(string[] args) {

            Notas aluno = new Notas();

            Console.Write("Digite o nome do Aluno = ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota 1 = ");
            aluno.Bi1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2 = ");
            aluno.Bi2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3 = ");
            aluno.Bi3 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(aluno);
        }
    }
}
