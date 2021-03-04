using System;

namespace _3._Gasolina {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Gasolina");
            Console.WriteLine();

            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            Console.Write("Digite o código do combustível: ");
            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1) {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 2) {
                    alcool = alcool + 1;
                }
                else if (tipo == 3) {
                    diesel = diesel + 1;
                }
                else if (tipo > 4) {
                    Console.WriteLine("Código inválido");
                }
                Console.Write("Digite o código do combustível: ");
                tipo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Muito Obrigado!!");
            Console.WriteLine("Gasolina = " + gasolina);
            Console.WriteLine("Alcool = " + alcool);
            Console.WriteLine("Diesel = " + diesel);
        }
    }
}
