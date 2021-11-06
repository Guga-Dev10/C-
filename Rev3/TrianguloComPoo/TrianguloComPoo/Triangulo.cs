using System;

namespace TrianguloComPoo
{
    class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangulo()
        {
        }

        public double PerimetroTriangulo()
        {
            double p = (A + B + C) / 2;
            return p;
        }

        public double AreaTriangulo()
        {
            double p = PerimetroTriangulo();
            double a = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return a;
        }
    }
}