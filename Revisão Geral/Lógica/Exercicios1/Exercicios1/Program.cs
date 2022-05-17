using System;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1 

            /*  Faça um programa para ler dois números inteiros e depois mostrar na tela o valor desses números
             com uma mensagem explicativa..
             */

            Console.WriteLine("Entre com dois números inteiros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int soma;
            Console.WriteLine($"Soma = {soma = n1 + n2}");

            // Exercício 2

            /* Faça um programa para ler o raio de um círculo e depois mostrar o valor da área do círculo
             com quatro casas decimais.
             */

            Console.WriteLine("\n");
            Console.Write("Entre com o valor do raio: ");
            int raio = int.Parse(Console.ReadLine());

            Console.WriteLine($"Circunferência = {circunferencia(raio).ToString("F4")}");

            // Exercício 3

            /* Faça um programa para ler quatro números inteiros e calcule a diferença entre os produtos de 
                A * B e C * D.
             */

            Console.WriteLine("\n");
            Console.WriteLine("Entre com o valor de quatro números inteiros: ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferencaProduto = (A * B) - (C * D);
            Console.WriteLine($"Diferença entre os Produtos = {diferencaProduto}");

            // Exercício 4

            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que 
             recebe por hora e calcule o salário do funcionário.
             */

            Console.WriteLine("\n");
            Console.WriteLine("Entre com os dados do funcionário: \n");
            Console.Write("Número do funcionário: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Valor da hora trabalhada: ");
            double valorHora = double.Parse(Console.ReadLine());

            double SalarioFuncionario = Salario(horasTrabalhadas, valorHora);
            Console.WriteLine($"Dados do funcionário: \nNúmero = {numeroFuncionario}, Salário = ${SalarioFuncionario.ToString("F2")}");
        }
        static double circunferencia(double raio)
        {
            double area = Math.PI * Math.Pow(raio, 2);
            return area;
        }
        static double Salario(int horasTrabalhadas, double valorHora)
        {
            return horasTrabalhadas * valorHora;
        }
    }
}
