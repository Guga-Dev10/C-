using System;
using System.Globalization;

namespace Media_Ponderada {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Media Ponderada");

            Console.WriteLine();
            Console.Write("Digite o número de repetições: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite três números reais na mesma linha:");
                string[] vet = Console.ReadLine().Split(' ');

                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double mediaponderada = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine("Media Ponderada = " 
                    + mediaponderada.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
        }
    }
}
