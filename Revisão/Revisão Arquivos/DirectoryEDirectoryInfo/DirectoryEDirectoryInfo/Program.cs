using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryEDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // O programa criou novos arquivos em uma pasta teste chamada: MyFolderTest

            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\MyFolderTest";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(
                    path, "*.*", SearchOption.AllDirectories);

                /* Outra forma de escrever o código acima: 
                 * 
                 * var folders = Directory.EnumerateDirectories(
                    path, "*.*", SearchOption.AllDirectories);
                 */
                Console.WriteLine("Folders: " + "\n");
                foreach(string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(
                    path, "*.*", SearchOption.AllDirectories);
               
               Console.WriteLine("Files: " + "\n");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                /*  Também funciona dessa forma
                 *  
                 *  DirectoryInfo Di = Directory.CreateDirectory(
                    @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\MyFolderTest\NewFolderTest"
                    ); 
                 */
                Directory.CreateDirectory(path + @"\NewFolderTest2");

                var newfolders = Directory.EnumerateDirectories(
                    path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("\n" + "New Folders Created: \n");
                foreach(string newfolder in newfolders)
                {
                    Console.WriteLine(newfolder);
                }
            }
            catch(IOException E)
            {
                Console.WriteLine("Error!! \n" + E.Message);
            }
        }
    }
}