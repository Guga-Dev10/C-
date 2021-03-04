using System;
using System.Globalization; 

namespace _1._Sem_Orientação_a_Objetos {
    class Program {
        static void Main(string[] args) {
            // Area do triângulo

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            Console.WriteLine();
            Console.WriteLine("Valor de P.X = " + p);
            Console.WriteLine("Valor da Area do triângulo X = " 
                + areaX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine();
            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Valor de P.Y = " + p);
            Console.WriteLine("Valor da Area do triângulo Y = "
                + areaY.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine();
            if (areaX > areaY) {
                Console.WriteLine("Maior area é = "
                    + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Maior area é = " 
                    + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
        }
    }
}
