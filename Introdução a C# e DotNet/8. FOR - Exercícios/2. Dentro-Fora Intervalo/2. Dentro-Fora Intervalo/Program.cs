using System;

namespace _2._Dentro_Fora_Intervalo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dentro/Fora");

            Console.WriteLine();
            Console.Write("Digite o número de repetições: ");
            int n = int.Parse(Console.ReadLine());

            int somadentro = 0;
            int somafora = 0;

            Console.WriteLine();
            for (int i = 0; i < n; i++) {
                Console.Write("Digite um número: ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20) {
                    Console.WriteLine("Dentro");
                    somadentro += x;
                }
                else {
                    Console.WriteLine("Fora");
                    somafora += x;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Soma dentro = " + somadentro);
            Console.WriteLine("Soma fora = " + somafora);
        }
    }
}
