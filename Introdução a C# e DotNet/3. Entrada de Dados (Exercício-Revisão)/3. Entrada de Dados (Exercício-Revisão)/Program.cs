using System;
using System.Globalization;

namespace _3._Entrada_de_Dados__Exercício_Revisão_ {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercício/Revisão");

            /* Fazer um programa com as seguintes intereações: Nome, quartos, preço. Depois
             * o programa deverá ler na mesma linha o nome, idade e altura.
             */

            Console.WriteLine();

            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos há em sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do produto? ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados inseridos: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("Digite seu nome, idade e altura na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');

            string nome1 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados inseridos no vetor:");
            Console.WriteLine($"Nome = {nome1}");
            Console.WriteLine($"Idade = {idade}");
            Console.WriteLine("Altura = " + altura.ToString(CultureInfo.InvariantCulture));
        }
    }
}
