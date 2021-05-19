using System;
using System.IO;

namespace FileEFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\File.txt";
            string targetPath = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred! \n" + e.Message);
            }
        }
    }
}