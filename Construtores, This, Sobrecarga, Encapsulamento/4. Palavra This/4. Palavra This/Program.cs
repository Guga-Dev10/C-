using System;
using System.Globalization;

namespace _4._Palavra_This {
    class Program {
        static void Main(string[] args) {

            CultureInfo Ci = CultureInfo.InvariantCulture;

            Console.Write("Nome do produto = ");
            string nome = Console.ReadLine();
            Console.Write("Preço do produto = ");
            double preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            Console.WriteLine(p);
        }
    }
}
