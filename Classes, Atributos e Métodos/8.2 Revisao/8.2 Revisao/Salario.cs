using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2_Revisao {
    class Salario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public Salario (string nome, double salario, double imposto) {
            Nome = nome;
            SalarioBruto = salario;
            Imposto = imposto;
        }

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(double porcentagem) {
            double Aumento = SalarioBruto * (porcentagem / 100);
            SalarioBruto += Aumento;
        }


    }
}
