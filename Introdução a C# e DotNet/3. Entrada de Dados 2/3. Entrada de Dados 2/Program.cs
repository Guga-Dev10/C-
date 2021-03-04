using System;
using System.Globalization;

namespace _3._Entrada_de_Dados_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número: ");

            int idade = int.Parse(Console.ReadLine());
            /*
             * O comando "Console.ReaLine" não reconhece nenhum outro tipo de dados
             * a não ser que seja um "String". Para que ele reconheça um outro tipo de dados
             * é preciso converter o tipo, ou seja, escrever "int.Parse" antes de "Console.ReadLine".
             */

            Console.WriteLine("Você digitou {0}", idade);

            Console.WriteLine();
            Console.WriteLine("Digite o sexo M/F: ");

            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine($"O sexo é: {sexo}");

            Console.WriteLine();
            Console.WriteLine("Digite um número real: ");
            double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O número real digitado é: {real.ToString(CultureInfo.InvariantCulture)}");

            Console.WriteLine("Ler com Split: ");

            string[] vet = Console.ReadLine().Split(' '); // inserir: Maria F 23 1.68
            string nome = vet[0];
            char sexo1 = char.Parse(vet[1]);
            int idade1 = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Variaveis divididas: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo1);
            Console.WriteLine("Idade: " + idade1);
            Console.WriteLine("Altura: " + altura.ToString(CultureInfo.InvariantCulture));
        }
    }
}