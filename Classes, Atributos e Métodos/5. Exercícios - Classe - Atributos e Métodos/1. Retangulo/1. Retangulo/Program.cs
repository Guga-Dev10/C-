using System;

namespace _1._Retangulo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Retângulo Exercício");
            Console.WriteLine();

            Retangulo Ret = new Retangulo();

            Console.Write("Digite a Largura do Retângulo: ");
            Ret.Largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a Altura do Retângulo: ");
            Ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(Ret);
        }
    }
}
