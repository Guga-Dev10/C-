using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Revisão do exercício 

            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\Exercicio Arquivos\Produtos.csv";

            Console.WriteLine("Found Data in file: \n");
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }            
        }
    }
}
