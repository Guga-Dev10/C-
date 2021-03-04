using System;
using System.Collections.Generic;
using System.Globalization;

namespace _9._1_Listas___Revisao {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            List<string> lista = new List<string>();

            List<string> Santos = new List<string> { 
                "Santo Antônio", 
                "Santo Agostinho" 
            };

            Santos.Add("Santo Anselmo");
            Santos.Add("Santa Catarina");
            Santos.Add("Santa Josefina");

            foreach (string obj in Santos) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("**************");    

            Santos.Insert(1, "Santa Genoveva");
            Santos.Insert(4, "Santa Margarida");
            Santos.Insert(6, "Santa Cecília");

            foreach (string obj in Santos) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("List Count = " + Santos.Count + " Elemento(s)");
            Console.WriteLine("**************");

            string s1 = Santos.Find(x => x[0] == 'S');
            Console.WriteLine("Primeira Pessoa com a letra inicial 'S' = " + s1);
            Console.WriteLine("**************");

            string s2 = Santos.FindLast(x => x[0] == 'S');
            Console.WriteLine("Última pessoa com letra incial 'S' = " + s2);
            Console.WriteLine("**************");

            int pos1 = Santos.FindIndex(x => x[0] == 'S');
            Console.WriteLine("Posição do primeiro com 'S' = " + pos1);
            Console.WriteLine("**************");

            int pos2 = Santos.FindLastIndex(x => x[0] == 'S');
            Console.WriteLine("Posição do último com 'S' = " + pos2);
            Console.WriteLine("**************");

            List<string> Resultado = Santos.FindAll(x => x.Length == 13);

            foreach (string obj in Resultado) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("**************");

            Santos.Remove("Santo Anselmo");
            foreach (string obj in Santos) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count = " + Santos.Count + " Elemento(s)");
            Console.WriteLine("**************");

            Santos.RemoveAll(x => x[0] == 'S');
            foreach (string obj in Santos) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count = " + Santos.Count + " Elemento(s)");
            Console.WriteLine("**************");

            Santos.Add("Santo Anselmo");
            Santos.Add("Santa Catarina");
            Santos.Add("Santa Josefina");

            foreach (string obj in Santos) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count = " + Santos.Count + " Elemento(s)");
            Console.WriteLine("**************");

            Santos.RemoveAt(2);
            foreach (string obj in Santos) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count = " + Santos.Count + " Elemento(s)");
            Console.WriteLine("**************");

            Santos.Add("Santo Irineu");
            Santos.Add("Santa Teresa D'Avila");
            Santos.Add("Santa Margarida"); 
            Santos.Add("Santo Inácio");
            Santos.Add("Santa Catarina de Sena");
            Santos.Add("Santa Josefina Bakhita");

            foreach (string obj in Santos) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count = " + Santos.Count + " Elemento(s)");
            Console.WriteLine("**************");

            Santos.RemoveRange(5, 2);
            foreach (string obj in Santos) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count = " + Santos.Count + " Elemento(s)");
            Console.WriteLine("**************");

        }
    }
}
