using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\Exercicio\Produtos.csv";
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

                // Consegui pegar o arquivo e ler com o .NET
                // Ele está separado por nome, preço e quantidade
            }
        }
    }
}
