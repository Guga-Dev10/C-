using System;
using Retangulo.Entities;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Medidas M = new Medidas(altura, largura);

            Console.WriteLine("\nÁrea: " + M.Area());
            Console.WriteLine("Perimetro: " + M.Perimetro());
            Console.WriteLine("Diagonal: " + M.Diagonal());
        }
    }
}
