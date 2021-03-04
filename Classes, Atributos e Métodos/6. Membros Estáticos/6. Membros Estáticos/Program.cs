using System;
using System.Globalization;
namespace _6._Membros_Estáticos {
    class Program {
        static void Main(string[] args) {

            // Calculadora de Circunferência e Volume
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor do raio = ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Valor de Pi = " + Calculadora.Pi);
            Console.WriteLine("Valorda Circunferência = " + circ.ToString("F2", CI));
            Console.WriteLine("Valor do Volume = " + vol.ToString("F2" + CI));
        }
    }
}
