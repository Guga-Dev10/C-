using System;
using System.Globalization;

namespace _3._Entrada_de_Dados__Exercicio_ {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercício de fixação");
            Console.WriteLine();

            /*
             * Fazer um programa com as seguintes interações com o usuário: 
             * 
             * Nome completo: Alex Green
             * Quantos quartos tem na casa: 3 
             * Preço de um produto: 500.50
             * 
             * Entre com o seu último nome, quartos e preço (mesma linha)
             */

            Console.WriteLine("Digite seus dados: ");
            Console.WriteLine();
            Console.WriteLine("Nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos há em sua casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Digite seu último nome, idade e altura na mesma linha: ");

            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"{nome} tem {quartos} quartos em sua casa com camas que" +
                $" valem R$ {preco}");
            Console.WriteLine();
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));
        }
    }
}
