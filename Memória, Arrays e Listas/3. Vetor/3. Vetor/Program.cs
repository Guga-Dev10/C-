using System;

namespace _3._Vetor {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantas posições terá o vetor? ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            Console.WriteLine("Digite os números do vetor: ");

            double soma = 0;
            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine());
                soma += vect[i];
            }
            Console.WriteLine();
            Console.WriteLine("Números do Vetor: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(vect[i]);
            }

            double media = soma / n;
            Console.WriteLine("Media = " + media);
        }
    }
}
