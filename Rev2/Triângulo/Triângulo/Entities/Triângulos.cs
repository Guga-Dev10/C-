using System;

namespace Triângulo.Entities
{
    class Triângulos
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triângulos()
        {
        }
        public Triângulos(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double perimetroTriangulo()
        {
            double perimetro = 0;
            return perimetro = (A + B + C) / 2;
        }
        public double areaTriangulo()
        {
            double p = perimetroTriangulo();
            double area = 0;
            return area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
