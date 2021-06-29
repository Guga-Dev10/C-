using System;
using Triângulo.Entities;

namespace Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor dos triângulos para o cálculo do perimetro! \n");
            Console.Write("Insira os valores do Triângulo A: \n");
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            Triângulos TA = new Triângulos(A, B, C);

            Console.WriteLine();
            Console.Write("Insira os valores do Triângulo B: \n");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            
            Triângulos TB = new Triângulos(A, B, C);

            Console.WriteLine("Perimetro Triângulo A = " + TA.perimetroTriangulo());
            Console.WriteLine("Area A = " + TA.areaTriangulo());
            Console.WriteLine("Perimetro Triângulo B = " + TB.perimetroTriangulo());
            Console.WriteLine("Area B = "  + TB.areaTriangulo());
        }
    }
}
