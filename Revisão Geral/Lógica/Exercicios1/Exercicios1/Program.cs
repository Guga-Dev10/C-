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

        }
        static double circunferencia(double raio)
        {
            double area = Math.PI * Math.Pow(raio, 2);
            return area;
        }
    }
}
