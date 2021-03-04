using System;

namespace _8._2_Revisao_Exercicio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("pensionato da Srta Peregrini");

            Console.Write("Quantos quartos há no pensionato? ");
            int quartos = int.Parse(Console.ReadLine());

            Quartos[] Q = new Quartos[quartos];

            Console.WriteLine();
            Console.Write("Deseja iniciar algum aluguel de quarto? (S/N) ");
            char resp = char.Parse(Console.ReadLine());

            Console.WriteLine();
            if (resp == 'S' || resp == 's') {
                Console.Write("Quantos estudantes irão alugar o quarto? ");
                int estudantes = int.Parse(Console.ReadLine());
                
                Console.WriteLine();
                for (int i = 0; i < estudantes; i++) {
                    Console.Write("Nome = ");
                    string nome = Console.ReadLine();
                    Console.Write("Email = ");
                    string email = Console.ReadLine();
                    Console.Write("Qual quarto deseja alugar? ");
                    int numeroquarto = int.Parse(Console.ReadLine());

                    Q[numeroquarto] = new Quartos { Nome = nome, Email = email, NumeroQuarto = numeroquarto };
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Quartos ocupados na Pensão: ");
                Console.WriteLine();

                for (int i = 0; i < quartos; i++) {
                    if (Q[i] == null) {
                        Console.WriteLine(i + "º" + " Quarto desocupado!");
                        Console.WriteLine();
                    }
                    else {
                        Console.WriteLine(i + "º " + Q[i]);
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Fim do programa!");
        }
    }
}
