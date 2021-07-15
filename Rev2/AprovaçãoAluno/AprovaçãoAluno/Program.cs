using System;
using AprovaçãoAluno.Entities;

namespace AprovaçãoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do Aluno: \n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nota do 1º trimestre: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota do 2º trimestre: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Nota do 3º trimestre: ");
            double n3 = double.Parse(Console.ReadLine());

            NotasAluno NA = new NotasAluno(nome, n1, n2, n3);

            Console.WriteLine(NA);
        }
    }
}
