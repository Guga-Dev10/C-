using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\Directory DirectoryInfo\MyFolderTest";

            try
            {
                IEnumerable<string> folderlist = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                // "*.*" é uma mascara de busca para listar arquivos que significa =
                // listar arquivos e qualquer extensão
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folderlist)
                {
                    Console.WriteLine(s);
                }
                
                var fileslist = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                // Pode-se usar o 'var' no lugar de IEnumerable
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("FILES: ");
                foreach(string s in fileslist)
                {
                    Console.WriteLine(s);
                }

                // Criando uma nova pasta
                Directory.CreateDirectory(path + @"\NewFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
