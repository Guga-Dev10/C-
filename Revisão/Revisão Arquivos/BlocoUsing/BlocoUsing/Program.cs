using System;
using System.IO;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  O using block é uma sintexe simplificada que garante que objetos
             *  IDisposable sejam fechados. Esses objetos não são gerenciados pelo CLR
             *  e precisam ser fechados manualmente, ojetos como por exemplo: Font, FileStream,
             *  StreamReader, StreamWriter.
             */
            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\File.txt";

            /* Forma longa
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            */

            // Forma Curta
            try {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException E)
            {
                Console.WriteLine("An error ocurred! \n" + E.Message);
            }
        }
    }
}
