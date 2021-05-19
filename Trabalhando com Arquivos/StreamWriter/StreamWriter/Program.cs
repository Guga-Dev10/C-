using System;
using System.IO;

namespace StreamWriterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string SourcePath = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\StreamWriter\File.txt";
                string TargetPath = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\StreamWriter\File2.txt";

                string[] lines = File.ReadAllLines(SourcePath);

                using (StreamWriter sw = File.AppendText(TargetPath)) 
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
