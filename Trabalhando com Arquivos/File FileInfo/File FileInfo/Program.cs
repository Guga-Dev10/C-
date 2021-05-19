using System;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\File FileInfo\File.txt";
            string targetPath = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\File FileInfo\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] files = File.ReadAllLines(sourcePath);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!! \n" + e.Message);
            }
        }
    }
}
