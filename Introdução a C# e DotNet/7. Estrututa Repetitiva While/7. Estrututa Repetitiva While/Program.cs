using System;
using System.Globalization;

namespace _7._Estrututa_Repetitiva_While {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("While");

            Console.WriteLine();
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Enquanto o número não for negativo o programa irá continuar executando...

            while (x >= 0) {
            
                    double raiz = Math.Sqrt(x);
                    Console.WriteLine($"Raiz de {x} é = {raiz.ToString("F3", CultureInfo.InvariantCulture)}");
                    Console.WriteLine();
                    Console.Write("Digite um número: ");
                     x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }
            Console.WriteLine("Número negativo!!");
        }
    }
}
