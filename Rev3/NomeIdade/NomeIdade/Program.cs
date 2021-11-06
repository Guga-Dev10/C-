using System;

namespace NomeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com os dados pessoais:\n");

            Pessoas A, B;
            A = new Pessoas();
            B = new Pessoas();

            Console.Write("Qual o nome da pessoa A: ");
            A.Nome = Console.ReadLine();
            Console.Write("Qual a idade da pessoa A: ");
            A.Idade = int.Parse(Console.ReadLine());

            Console.Write("\nQual o nome da pessoa B: ");
            B.Nome = Console.ReadLine();
            Console.Write("Qual a idade da pessoa B: ");
            B.Idade = int.Parse(Console.ReadLine());

            if(A.Idade > B.Idade)
            {
                Console.WriteLine("\nA pessoa mais velha é: " + A.Nome);
            }
            else if(A.Idade < B.Idade)
            {
                Console.WriteLine("\nA pessoa mais velha é: " + B.Nome);
            }
            else
            {
                Console.WriteLine("\nAs duas pessoas possuem a mesma idade");
            }
        }
    }
}
