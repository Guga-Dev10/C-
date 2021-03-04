using System;
using System.Globalization;

namespace _1._Dolar___Membros_Estaticos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Revisão - Membros estáticos - Dólar");
            Console.WriteLine();

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a cotação do Dólar: ");
            double dolarpreco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a quantidade de dólares a serem comprados: ");
            double dolarquantidade = double.Parse(Console.ReadLine(), CI);

            double ValorReal = Conversor.ConversorDolarParaReal(dolarpreco, dolarquantidade);

            Console.WriteLine();
            Console.WriteLine("Resultado em Reais = " + ValorReal.ToString("F2", CI));
        }
    }
}
