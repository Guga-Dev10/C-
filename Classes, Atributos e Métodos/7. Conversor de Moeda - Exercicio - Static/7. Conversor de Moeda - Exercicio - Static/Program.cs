using System;
using System.Globalization;

namespace _7._Conversor_de_Moeda___Exercicio___Static {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a cotação do Dólar = ");
            double CotacaoDolar = double.Parse(Console.ReadLine(), CI);
            Console.Write("Qual a quantidade de dólares a serem comprados: ");
            double Quantidade = double.Parse(Console.ReadLine(), CI);
            Console.Write("Qual o valor do IOF = ");
            double IOF = double.Parse(Console.ReadLine(), CI);

            double ValorGasto = Conversor.Calculo(CotacaoDolar, Quantidade, IOF);

            Console.WriteLine("Valor em Reais = " + ValorGasto.ToString("F2", CI));
        }
    }
}
