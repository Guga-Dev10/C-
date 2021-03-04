using System;

namespace _1._Positivo_ou_Negativo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Positivo ou Negativo");

            Console.WriteLine("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            if (x < 0) {
                Console.WriteLine("Número negativo!!");
            }
            else if (x > 0) {
                Console.WriteLine("Número Positivo!!");
            }
            else {
                Console.WriteLine("Zero!!");
            }
        }
    }
}
