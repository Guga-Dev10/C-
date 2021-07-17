using System;
using Membros_Estaticos_Exercicio.Entities;

namespace Membros_Estaticos_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de doláres a serem comprados? ");
            double qteDolar = double.Parse(Console.ReadLine());

            double valorEmReais = ConversorDeMoedas.Conversor(cotacaoDolar, qteDolar);
            Console.WriteLine($"\n Cotação do dolar = {cotacaoDolar} " +
                $"\nDolares Comprados: {qteDolar}" +
                $"\nValor total em Reais: {valorEmReais}");
        }
    }
}
