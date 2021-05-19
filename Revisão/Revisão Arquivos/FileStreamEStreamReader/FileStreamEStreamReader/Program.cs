using System;
using System.IO;

namespace FileStreamEStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uma stream em informática é uma sequência de dados
             * Ele é um termo comum quando se transmite dados em sequência.
             * Por exemplo, o Netflix e o Twitch são serviços de Stream
             * 
             * FileStream = stream binária. Ele disponibiliza uma stream a partir de um arquivo, permitindo
             *      sua leitura e escrita.
             * StreamReader = stream de caracteres que é capaz de ler os dados a partir de uma stream binária.
             */

            string path = @"C:\Users\Gustavo Souza\Desktop\Curso C#\Revisão\Revisão Arquivos\File.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                /* Filestram associado a um arquivo com a finalidade 
                 * de acesso ao arquivo para disponibilizar sua leitura ou escrita
                 * 
                 * Em cima do FileStream o StramReader deve ser instanciado, dando o objeto
                 * de FileStream como argumento.
                 */
                sr = new StreamReader(fs);
                //A partir do objeto sr agora é possível fazer uma leitura do arquivo, por exemplo.

                string line = sr.ReadLine(); //Irá ler uma linha do arquivo e a armazenará na string line.]
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred! \n" + e.Message);
            }
            finally
            {
                /* As stream instanciadas (FileStream e StreamReader) são recursos externos e 
                 * não são controladas pelo clr do .NET
                 * Elas são uma "conversa com o SO" então elas devem ser fechadas manualmente
                 */
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
