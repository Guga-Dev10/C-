using System;
using System.IO;

namespace PathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Trabalhando com Arquivos\Path\File.txt";
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
