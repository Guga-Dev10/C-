using System;
using System.Collections.Generic;
using System.Text;

namespace _8._Revisao {
    class Retangulo {

        public double Altura;
        public double Largura;

        public Retangulo (double altura, double largura) {
            Altura = altura;
            Largura = largura;
        }

        public double AreaRetangulo() {
            double area = Altura * Largura;
            return area;
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
