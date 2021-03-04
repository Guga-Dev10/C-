using System;
using System.Globalization;
using System.Text;

namespace _2._Funcionario {
    class Salario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            double salarioreal = SalarioBruto - Imposto;
            return salarioreal;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString() {
            return "Nome = "
                + Nome
                + " ; Salário Liquído = "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
