using System;

namespace NomeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários? ");
            int qte = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o nome do funcionário: ");
            string nome1 = Console.ReadLine();
            Console.Write("Digite o salario do funcionário: ");
            double salario1 = double.Parse(Console.ReadLine());

            Funcionario f1 = new Funcionario(nome1, salario1);
            
            Console.Write("\nDigite o nome do funcionário: ");
            string nome2 = Console.ReadLine();
            Console.Write("Digite o salario do funcionário: ");
            double salario2 = double.Parse(Console.ReadLine());

            Funcionario f2 = new Funcionario(nome2, salario2);

            double Media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("\nA média de Salários é: " + Media);
        }
    }
}
