using System;

namespace _3._3_Vetor___Exercicio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Pensionato estudantil com 10 quartos ");
            Console.WriteLine();

            int n = 10;

            Dados[] DadosEstudantes = new Dados[n];
            Console.WriteLine();

            Console.Write("Quantos estudantes irão se hospedar? ");
            int quant = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < quant; i++) {
                Console.Write("Digite o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o E-mail do estudante: ");
                string email = Console.ReadLine();
                Console.Write("Número do quarto em que irá se hospedar: ");
                int quarto = int.Parse(Console.ReadLine());

                DadosEstudantes[quarto] = new Dados(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < n; i++) {
               // if (DadosEstudantes[i] != null) 
                    Console.WriteLine($"Quarto {i} = " + DadosEstudantes[i]);
                
            }
        }
    }
}
