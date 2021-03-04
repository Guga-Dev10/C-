using System;
using System.Globalization;

namespace _2._Euro___Real {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Membros Estáticos - Euro - Real - Conversão");
            Console.WriteLine();

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a cotação do Euro = ");
            double CotacaoEuro = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a quantidade de Euros que será comprada = ");
            double QuantidadeEuro = double.Parse(Console.ReadLine(), CI);

            double ValorReal = Conversor.ConversorEuroReal(CotacaoEuro, QuantidadeEuro);

            Console.WriteLine();
            Console.WriteLine("Valor em Reais = $" + ValorReal.ToString("F2", CI));
        }
    }
}
