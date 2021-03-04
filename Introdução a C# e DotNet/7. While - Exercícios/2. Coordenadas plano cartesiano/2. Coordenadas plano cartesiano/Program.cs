using System;

namespace _2._Coordenadas_plano_cartesiano {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Coordenadas");

            Console.WriteLine();
            Console.Write("Eixo X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Eixo Y: ");
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo quadrante");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro quadrante");
                }
                else {
                    Console.WriteLine("Quarto quadrante");
                }
                Console.WriteLine();
                Console.Write("Eixo X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Eixo Y: ");
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("NULO!!!");
        }
    }
}
