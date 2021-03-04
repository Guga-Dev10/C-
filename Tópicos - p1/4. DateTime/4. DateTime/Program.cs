using System;
using System.Globalization;

namespace _4._DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime D1 = DateTime.Now;

            Console.WriteLine(D1);
            Console.WriteLine(D1.Ticks);

            DateTime D2 = new DateTime(2021, 03, 01);
            DateTime D3 = new DateTime(2021, 03, 01, 16, 10, 15); 
                                    // ano, mes, dia, hora, minuto, segundo
            DateTime D4 = new DateTime(2021, 03, 01, 16, 10, 15, 500); // Não suporta milissegundos

            Console.WriteLine();
            Console.WriteLine(D2);
            Console.WriteLine(D3);
            Console.WriteLine(D4);

            DateTime D5 = DateTime.Today;
            DateTime D6 = DateTime.UtcNow;

            Console.WriteLine(D5);
            Console.WriteLine(D6);

            CultureInfo CI = CultureInfo.InvariantCulture;

            DateTime D7 = DateTime.Parse("2021-01-01");
            DateTime D8 = DateTime.Parse("2020-01-01 14:25:10");
            DateTime D9 = DateTime.Parse("10/11/2014");

            Console.WriteLine(D7);
            Console.WriteLine(D8);
            Console.WriteLine(D9);

            DateTime D10 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(D10);
        }
    }
}
