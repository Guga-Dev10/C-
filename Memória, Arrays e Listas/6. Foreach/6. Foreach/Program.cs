using System;

namespace _6._Foreach {
    class Program {
        static void Main(string[] args) {

            string[] vect = new string[] { "Maria", "Alex", "João" };

            // Usando For para imprimir todos os elementos do vetor

            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-----------------------");

            // usando ForEach para imprimir todos os elementos String do vetor

            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
