using System;
using Membros_Estaticos.Entities;

namespace Membros_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando membros estáticos á partir de classes

            // Esses objetos estáticos serão fórmulas matemáticas para cálcuios envolvendo círculos

            /* colocando um comando static nas funções permite que eles possam ser chamados 
            * em outras partes do código sem precisar de instânciação 
            * 
            * Para usar os membros estáticos no arquivo principal é necessário usar o nome da classe em
            * que ele foi declarado, no caso foi a classe CALCULADORA
            */

            Console.Write("Entre com o valor do Raio: ");
            double r = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(r);
            double volume = Calculadora.Volume(r);

            Console.WriteLine("Circunferência = " + circ);
            Console.WriteLine("Volume = " + volume);
            Console.WriteLine("Pi = " + Calculadora.Pi);
        }
    }
}
