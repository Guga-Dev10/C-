using System;
using System.Globalization;
using FuncionarioSalario.Entities;

namespace FuncionarioSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Informe os dados do funcionário \n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Impostos: ");
            double imposto = double.Parse(Console.ReadLine(), CI);

            Funcionario f = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine(f);

            Console.Write("\nPorcentagem do Aumento salarial: ");
            double porcentagem = double.Parse(Console.ReadLine());

            f.AumentarSalario(porcentagem);

            Console.WriteLine("\n" + f);
        }
    }
}
