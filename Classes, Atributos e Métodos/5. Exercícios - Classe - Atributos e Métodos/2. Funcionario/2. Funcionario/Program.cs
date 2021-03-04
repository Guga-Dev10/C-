using System;

namespace _2._Funcionario {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Salário de Funionário");
            Console.WriteLine();

            Salario func = new Salario();

            Console.Write("Digite o nome do funcionário = ");
            func.Nome = Console.ReadLine();
            Console.Write("Digite o salário bruto = ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Digite o imposto a ser abatido = ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(func);
            Console.WriteLine();

            Console.Write("Digite a pocentagem de aumento salarial = ");
            double porc = double.Parse(Console.ReadLine());
            func.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine(func);

        }
    }
}
