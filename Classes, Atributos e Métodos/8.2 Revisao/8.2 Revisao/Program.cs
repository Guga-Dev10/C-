using System;
using System.Globalization;

namespace _8._2_Revisao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Salário de Funcionário");

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine();
            Console.Write("Digite o nome do funcionário = ");
            string nome = Console.ReadLine();
            Console.Write("Digite o salário bruto = ");
            double salario = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a quantidade de Imposto = ");
            double imposto = double.Parse(Console.ReadLine(), CI);

            Salario S = new Salario(nome, salario, imposto);

            Console.WriteLine();
            Console.WriteLine("Salario Líquido = " + S.SalarioLiquido().ToString("F2", CI));

            Console.WriteLine();
            Console.Write("Porcentagem de Aumento Salarial = ");
            double porcentagem = double.Parse(Console.ReadLine(), CI);
            S.AumentoSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Salario Líquido com Aumento = " + S.SalarioLiquido().ToString("F2", CI));
        }
    }
}
