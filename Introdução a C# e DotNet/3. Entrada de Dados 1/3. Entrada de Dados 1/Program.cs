using System;

namespace _3._Entrada_de_Dados_1 {
    class Program {
        static void Main(string[] args) {

                Console.WriteLine("Digite uma frase: ");

                string frase = Console.ReadLine();

                Console.WriteLine("Você digitou: " + frase);

                /*
                 * O comando Split consegue reconhecer e armazenar em variáveis diferentes
                 * cada palavra que contenha em uma frase. Depois que o Split separar dentro
                 * de um vetor cada variável dentro de uma frase, pode ser adicionado esses valores
                 * em uma variável.
                 */
                Console.WriteLine();
                Console.WriteLine("Digite outra frase: ");
                string s = Console.ReadLine();

                string[] vet = s.Split(' ');
                // String[] vet = console.ReadLine().Split(' '); também pode ser usado;

                string a = vet[0];
                string b = vet[1];
                string c = vet[2];
                string d = vet[3];
                string e = vet[4];

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(e);
        }
    }
}
