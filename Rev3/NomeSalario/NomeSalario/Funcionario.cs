namespace NomeSalario
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public double MediaSalario(double salario1, double salario2)
        {
            return (salario1 + salario2) / 2;
        }
    }
}
