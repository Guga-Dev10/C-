using System;
using System.IO;

namespace FileStramEStreamReader2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uma outra forma de economizar linhas e códigos para executar uma leitura de arquivos
             */
            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\File.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                //Para ler todas as linhas de texto do arquivo e não apenas uma
                while (!sr.EndOfStream) // Enquanto Não chegar o final da Stream de sr, faça:
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred! \n" + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}