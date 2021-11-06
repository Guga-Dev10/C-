using System;
using System.Globalization;

namespace TrianguloComPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Triangulo X, Y;

            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Entre com os dados do triângulo X: ");
            X.A = double.Parse(Console.ReadLine(), CI);
            X.B = double.Parse(Console.ReadLine(), CI);
            X.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("\nEntre com os dados do Triângulo Y: ");
            Y.A = double.Parse(Console.ReadLine(), CI);
            Y.B = double.Parse(Console.ReadLine(), CI);
            Y.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("\nResultados do triângulo X: " +
                "\nPerimetro = " + X.PerimetroTriangulo().ToString("F2",CI)
                + "\nÁrea = " + X.AreaTriangulo().ToString("F2", CI));
            
            Console.WriteLine("\nResultados do triângulo Y: " +
                "\nPerimetro = " + Y.PerimetroTriangulo().ToString("F2",CI)
                + "\nÁrea = " + Y.AreaTriangulo().ToString("F2", CI));
        }
    }
}
