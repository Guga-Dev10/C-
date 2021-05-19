using System;
using System.IO;

namespace FileStram_StramReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\FileStram StramReader\File.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                /*
                 * Uma das formas de se usar o código
                fs = new FileStream(path, FileMode.Open); 
                sr = new StreamReader(fs);
                string line = sr.ReadToEnd(); // Lê o arquivo todo de uma vez
                Console.WriteLine(line);
                */

                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {   
                    // Outra forma mais resumida de se usar o código e fazê-lo ler linha por 
                    // linha até o final do texto
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!! \n" + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                // if (fs != null) fs.Close();
            }
        }
    }
}
