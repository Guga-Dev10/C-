using System;
using System.Globalization;

namespace _8._4_Revisao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Conversor de Moeda");

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine();
            Console.Write("Quantos dólares deseja comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CI);

            ConversorDeMoeda C = new ConversorDeMoeda();
            C.Dolar = dolar;

            Console.WriteLine();
            Console.WriteLine("Valor em Reais = R$" + C.ConversorDolarParaReal().ToString("F2", CI));
        }
    }
}
