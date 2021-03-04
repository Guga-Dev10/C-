using System;
using System.Collections.Generic;

namespace _7._Listas {
    class Program {
        static void Main(string[] args) {

            // Para se usar uma List deve=se usar a biblioteca "using System.Collections.Generic;"
            // pois a Classe List está contida dentro da biblioteca

            List<string> criada;
            
            List<string> lista = new List<string>(); // Lista criada e instânciada vazia

            List<string> nomes = new List<string> { "Maria", "João", "Gabriel" };
            // Lista criada, instanciada e com elementos.

            /* Vantagens de uma Lista: 
             *      Tamanho variável
             *      Facilidade para realizar inserções e deleções
             *      
             * Desvantagem: 
             *      Acesso sequencial aos elementos
             */

            lista.Add("Ana");
            lista.Add("Mayara"); // o Add adiciona elementos ao final de uma lista
            lista.Add("Guilherme");
            lista.Add("Thiago");
            lista.Insert(1, "Renato"); // O Insert coloca o elemento na posição que você declarar inicialmente
            lista.Insert(3, "Antonio");

            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            Console.WriteLine($"Quantidade de elementos na Lista = {lista.Count} elementos");
            Console.WriteLine($"Quantidade de elementos em Nomes = {nomes.Count} elementos");
            Console.WriteLine();

            string s1 = lista.Find(x => x[0] == 'A'); // Encontra a primeira pessoa cujo o nome comece com "A"
            Console.WriteLine("Primeiro com A = " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A'); // Encontra a última pessoa cujo o nome comece com "A"
            Console.WriteLine("Último com A = " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A'); // Encontra a posição do primeiro elemento que comece com "A"
            Console.WriteLine("Posição do primeiro com 'A' = " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A'); // Encontra a posição do último elemento que comece com "A"
            Console.WriteLine("Posição do último com 'A' = " + pos2);

            List<string> Lista2 = lista.FindAll(x => x[0] == 'A');

            Console.WriteLine();
            Console.WriteLine("Nomes com iniciais A = "); 
            foreach (string obj in Lista2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------");
            lista.Remove("Thiago");
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------");
            lista.RemoveAll(x => x[0] == 'A');
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------");
            lista.RemoveAt(2);
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            lista.Add("Natanael");
            Console.WriteLine("---------------");
            lista.RemoveRange(0, 2);
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }
        }
    }
}
