using System;
using System.IO;

namespace StreamWriterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* É uma stream capaz de escrever caracteres a partir de uma stream binária
             */

            string sourcePath = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\File.txt";
            string targetPath = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\File3ToUpper.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    // AppendText abre um arquivo para escrita
                    foreach(string line in lines)
                    {
                        // Para cada linha no vetor de linhas escreva essas linhas no arquivo alvo
                        sw.WriteLine(line.ToUpper());
                        //Todas as linhas do arquivo alvo devem estar em MAIÚSCULO  
                    }
                }

                /* Aqui eu criei um código além do exemplo do professor e pedi que além de criar 
                 * um novo arquivo e colocasse todas as linhas com letras maiúsculas, o programa
                 * também deve pegar esse novo arquivo escrito e mostrar as modificações na tela.
                 */
                string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\File3ToUpper.txt";

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException E)
            {
                Console.WriteLine("Error! \n" + E.Message);
            }
        }
    }
}