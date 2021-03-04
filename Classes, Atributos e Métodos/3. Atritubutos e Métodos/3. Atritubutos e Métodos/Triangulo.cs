using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Atritubutos_e_Métodos {
    class Triangulo {

        public double A; // Atributo
        public double B; // Atributo
        public double C; // Atributo

        //  Método
        public double Area() {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
