using System;
using System.Globalization;

namespace _5._Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Preco p = new Preco("Tv", 900, 10);

            Console.WriteLine(p.GetNome());

            p.SetNome("Tv 4k");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetValor());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}