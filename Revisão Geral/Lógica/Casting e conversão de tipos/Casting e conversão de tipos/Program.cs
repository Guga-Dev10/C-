using System;

namespace Casting_e_conversão_de_tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* conversão implícita de tipo é quando o valor de um TIPO pode ser convertido e atribuído naturalmente 
             em outra variável de outro TIPO... Por exemplo: variável do tipo FLOAT pode ser atribuida dentro de uma variável do
            TIPO double.
            */

            //Conversão implícita
            float a = 4.5f;
            double x = a;
            Console.WriteLine(x);
            /*Porém o inverso não pode acontecer por causa do número de bites que os tipos suportam. O Tipo float pode suportar até
            quatro bites e o tipo double pode suportar até oito bites, por isso o float pode ser atribuido em um tipo double mas o tipo 
            double não pode ser atribuido em um tipo float.
            */

            //Conversão Casting

            double y = 4.58;
            float b = (float)y;
            Console.WriteLine(b);
            /* na conversão explícita(casting) o compilador permite que um TIPO com maiores quantidades de bites sejam convertido
             * em um tipo que possua uma menor quantidade de bites, porém poderá haver perda de informações, como no caso de se converter
             * uum TIPO double em um int.
             */

            double w = 3.5546;
            int i = (int)w;
            Console.WriteLine(i); //houve perda dos dados decimais

            //Divisão por inteiros usando casting

            int n = 5;
            int m = 2;
            double resultadoSemCating = n / m;
            double resultadoComCating = (double)n / m;
            Console.WriteLine(resultadoSemCating);
            Console.WriteLine(resultadoComCating);
        }
    }
}
