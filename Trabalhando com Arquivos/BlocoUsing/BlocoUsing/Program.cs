using System;
using System.IO;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\BlocoUsing\File.txt";

            try
            {
                // using FileStream fs = new FileStream(path, FileMode.Open);

                using StreamReader sr = File.OpenText(path);
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Error!! \n" + e.Message);
            }
        }
    }
}
