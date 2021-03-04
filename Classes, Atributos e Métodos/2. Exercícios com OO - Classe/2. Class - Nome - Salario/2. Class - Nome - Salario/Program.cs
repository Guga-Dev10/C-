using System;
using System.Globalization;

namespace _2._Class___Nome___Salario {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Class - Nome - Salário");
            Console.WriteLine();

            NomeSalario p1, p2;

            p1 = new NomeSalario();
            p2 = new NomeSalario();

            Console.Write("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite o salario da primeira pessoa: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite o salario da segunda pessoa: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double media = (p1.Salario + p2.Salario) / 2;
            Console.WriteLine("Media salarial = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
