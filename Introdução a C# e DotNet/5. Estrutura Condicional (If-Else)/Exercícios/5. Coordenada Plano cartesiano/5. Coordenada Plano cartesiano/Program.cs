using System;

namespace _5._Coordenada_Plano_cartesiano {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Coordenadas Plano Cartesiano");

            Console.WriteLine();
            Console.Write("Digite o eixo x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite o eixo y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            }
            else if(x < 0 && y > 0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            }
            else {
                Console.WriteLine("Origem");
            }
        }
    }
}
