using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Nome___Salario {
    class Dados {

        public string Nome;
        public double Salario;

        public Dados(string nome, double salario) {
            Nome = nome;
            Salario = salario;
        }

        public static double SalarioMedio(double salario1, double salario2) {
            double SalarioMedio = (salario1 + salario2) / 2;
            return SalarioMedio;
        }
    }
}
