using System;
using System.Globalization;

namespace _4._Saida_de_dados {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercício de fixação de saída de dados: ");
            Console.WriteLine();

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5230;
            char genero = 'M';

            double preco1, preco2, medida;
            preco1 = 2100;
            preco2 = 650.50;
            medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo o preço é R$ {preco1}."); //interpolação
            Console.WriteLine("{0}, cujo o preço é R$ {1}", produto2, preco2); // placeholder
            Console.WriteLine();

            Console.WriteLine($"Registro: {idade} anos, código {codigo} e gênero: {genero}");
            Console.WriteLine();

            Console.WriteLine("Medida com oito casas decimais: " + medida); // concatenação
            Console.WriteLine("Medida com três casas decimais: " + medida.ToString("F3"));
            Console.WriteLine("Medida com duas casas decimais: " + medida.ToString("F2"));

        }
    }
}