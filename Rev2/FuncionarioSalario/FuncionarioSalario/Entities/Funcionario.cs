using System.Globalization;

namespace FuncionarioSalario.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }

        CultureInfo CI = CultureInfo.InvariantCulture;
        public override string ToString()
        {
            return "Dados do funcionário \n"
                + "\nNome do funcionário: "
                + Nome
                + "\nSalário bruto: $"
                + SalarioBruto.ToString("F2", CI)
                + "\nImpostos: $"
                + Imposto.ToString("F2", CI)
                + "\nSalário líquido do Funcionário: $"
                + SalarioLiquido().ToString("F2", CI);
        }
    }
}
