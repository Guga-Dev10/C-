using System;


namespace _3._Atritubutos_e_Métodos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Calcular a Area do Triângulo");
            Console.WriteLine();

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os dados do Triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite os dados do Triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área X = " + areaX.ToString("F2"));
            Console.WriteLine("Área Y = " + areaY.ToString("F2"));
            Console.WriteLine();

            if (areaX > areaY) {
                Console.WriteLine("Maior área = " + areaX.ToString("F2"));
            }
            else if (areaY > areaX) {
                Console.WriteLine("Maior área = " + areaY.ToString("F2"));
            }
            else {
                Console.WriteLine("Áreas iguais!!");
            }
        }
    }
}
