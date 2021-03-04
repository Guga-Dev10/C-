using System;

namespace _3._2_Vetor___Class___Struct {
    class Program {
        static void Main(string[] args) {
            Console.Write("Tamanho do vetor: ");

            int n = int.Parse(Console.ReadLine());

            Produto[] Vet = new Produto[n];

            double soma = 0;
            for (int i = 0; i < n; i++) {
                Console.Write("Nome  do produto = ");
                string nome = Console.ReadLine();
                Console.Write("Preço do produto = ");
                double preco = double.Parse(Console.ReadLine());
                
                Vet[i] = new Produto (nome, preco);

                soma += Vet[i].Preco;
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++) {
                Console.WriteLine(Vet[i]);
            }

            double media = soma / n;
            Console.WriteLine("Media = $" + media);
        }
    }
}
