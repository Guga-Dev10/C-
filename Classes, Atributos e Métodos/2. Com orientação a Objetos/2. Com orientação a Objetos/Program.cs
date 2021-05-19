using System;
using System.Globalization;

namespace _2._Com_orientação_a_Objetos {
    class Program {
        static void Main(string[] args) { 
            
            // Area do triângulo

            Triangulo x, y, z;

            x = new Triangulo();
            y = new Triangulo();
            z = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Entre com as medidas do Triangulo Z: ");
            z.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine();
            Console.WriteLine("Valor de P.X = " + p);
            Console.WriteLine("Valor da Area do triângulo X = "
                + areaX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine();
            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Valor de P.Y = " + p);
            Console.WriteLine("Valor da Area do triângulo Y = "
                + areaY.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine();
            p = (z.A + z.B + z.C) / 2;
            double areaZ = Math.Sqrt(p * (p - z.A) * (p - z.B) * (p - z.C));

            Console.WriteLine("Valor de P.Z = " + p);
            Console.WriteLine("Valor da Area do triângulo Z = "
                + areaZ.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine();
            if (areaX > areaY && areaX > areaZ) {
                Console.WriteLine("Maior area é = "
                    + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else if (areaY > areaZ) {
                Console.WriteLine("Maior area é = "
                    + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
            else if (areaZ == areaY && areaZ == areaX) {
                Console.WriteLine("Areas iguais = X = {0}, Y = {1}, Z = {2}",
                    areaX.ToString("F4"), areaY.ToString("F4"), areaZ.ToString("F4"));
            } 
            else {
                Console.WriteLine("Maior area é = "
                    + areaZ.ToString("F4", CultureInfo.InvariantCulture));
            }
        }
    }
}