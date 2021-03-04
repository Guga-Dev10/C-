using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _1._Retangulo {
    class Retangulo {

        public double Largura;
        public double Altura;
        CultureInfo CI = CultureInfo.InvariantCulture;

        public double Area() {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro() {
            double perimetro = (Largura + Altura) * 2.0;
            return perimetro;
        }

        public double Diagonal() {
            double diagonal = Math.Sqrt((Altura * Altura) + (Largura * Largura));
            return diagonal;
        }

        public override string ToString() {
            return "Área = "
                + Area().ToString("F2", CI)
                + " ; Perimetro = "
                + Perimetro().ToString("F2", CI)
                + " ; Diagonal = "
                + Diagonal().ToString("F2", CI);
        }
    }
}
