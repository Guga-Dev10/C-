using System;
using System.Globalization;

namespace _7._Auto_Propriedades {
    class Program {
        static void Main(string[] args) {

            Preco p = new Preco("Tv", 900, 10);

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Valor);
            Console.WriteLine(p.Quantidade);

            p.Nome = "Tv 4k";
           // p.Valor = 1200;
            // p.Quantidade += 10;

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Valor);
            Console.WriteLine(p.Quantidade);
        }
    }
}

