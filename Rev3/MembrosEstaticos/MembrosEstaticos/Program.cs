using System;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantidade a ser comprada? ");
            double quantidade = double.Parse(Console.ReadLine());
            

            double cotacaoDoDolar = CotacaoDolar.Calculadora(dolar, quantidade);

            Console.Write("\nA cotação do dólar é: R$" + cotacaoDoDolar);
        }
    }
}
