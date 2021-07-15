using System;

namespace Retangulo.Entities
{
    class Medidas
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Medidas(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }
        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }
        public double Diagonal()
        {
            double diagonal;
            diagonal = Math.Sqrt((Altura * Altura) + (Largura * Largura));
            return diagonal;
        }
    }
}
