using System;

namespace Operadores_Aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Em uma operação matemática é necessário prestar atenção nos tipos de variáveis que são colocadas 
             * nas operações.
             */

            double x = 10 / 8; // o resultado será 1 por causa que o compilador entende que é uma operação INT apesar do DOUBLE
            Console.WriteLine(x);

            // Para funcionar é necessário que haja um casting para que o compilador entenda que precisa fazer 
            // uma 'conversão' e realmente execuar a operação como uma operação DOUBLE
            
            x = (double)10 / 8; // Assim o resulado retornará o valor verdadeiro sem perda de informações
            Console.WriteLine(x); // x = 1.25

            x = 10.0 / 8; //Neste caso o casting funcionará por conta do 'ponto' e o zero,
            // induzindo o compilador a entender que é uma operação DOUBLE
            Console.WriteLine(x);

            //Utilizando a função Math

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("\n" + $"Delta = {delta} \n x1 = {x1} \n x2 = {x2}");
        }
    }
}
