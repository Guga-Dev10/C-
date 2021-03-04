using System;

namespace _6._Imposto_de_Renda {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Imposto de Renda");

            Console.WriteLine();
            Console.Write("Digite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine());

            double imposto = 0;

            if (salario <= 2000) {
                Console.WriteLine("Isento de Imposto!");
            }
            else if (salario > 2000 && salario <= 3000) {
                imposto = (salario - 2000) * 0.08;
                Console.WriteLine($"Imposto de R${imposto.ToString("F2")} sobre o salário de R${salario}");
            }
            else if (salario > 3000 && salario <= 4500) {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine($"Imposto de R${imposto.ToString("F2")} sobre o salário de R${salario}");
            }
            else if (salario > 4500) {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine($"Imposto de R${imposto.ToString("F2")} sobre o salário de R${salario}");
            }
        }
    }
}
