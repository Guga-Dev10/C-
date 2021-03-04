using System;

namespace _4._Nome___Salario {
    class Program {
        static void Main(string[] args) {

            Console.Write("Nome da 1ª Pessoa = ");
            string Nome1 = Console.ReadLine();
            Console.Write("Salário da 1ª Pessoa = ");
            double Salario1 = double.Parse(Console.ReadLine());

            Dados Dp = new Dados(Nome1, Salario1);

            Console.WriteLine();
            Console.Write("Nome da 2ª Pessoa = ");
            string Nome2 = Console.ReadLine();
            Console.Write("Salário da 2ª Pessoa = ");
            double Salario2 = double.Parse(Console.ReadLine());

            Dados Dp2 = new Dados(Nome2, Salario2);

            double SalarioMedio = Dados.SalarioMedio(Salario1, Salario2);

            Console.WriteLine();
            Console.WriteLine("Salario Médio = " + SalarioMedio);
        }
    }
}
