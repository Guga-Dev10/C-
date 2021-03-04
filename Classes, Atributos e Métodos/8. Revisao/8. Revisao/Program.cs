using System;
using System.Globalization;

namespace _8._Revisao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Largura do retângulo");

            Console.WriteLine();

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Entre com a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Entre com a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine(), CI);

            Retangulo R = new Retangulo(altura, largura);

            Console.WriteLine();
            Console.WriteLine("Área = " + R.AreaRetangulo().ToString("F2",CI));
            Console.WriteLine("Perimetro = " + R.Perimetro().ToString("F2", CI));
            Console.WriteLine("Diagonal = " + R.Diagonal().ToString("F2", CI));
        }
    }
}
