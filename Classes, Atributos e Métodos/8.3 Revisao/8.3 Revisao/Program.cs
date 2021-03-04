using System;

namespace _8._3_Revisao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Aluno");

            Console.WriteLine();
            Console.Write("Nome = ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as notas = ");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            Aluno A = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine();
            Console.WriteLine(A);
        }
    }
}
