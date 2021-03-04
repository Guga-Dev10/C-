using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Tipos basicos de dados: ");

            sbyte x = 100;
            /* O sbyte permite valores numéricos inteiros que variam de - 128 à 127;
             */
            Console.WriteLine();
            Console.WriteLine(x);

            /* Caso uma variável seja introduzida com o valor superior à 127, acontecerá um 
             * evento chamado de Overflow. O Overflow é quando uma atribuição de valores ou
             * um cálculo supera o valor de uma variável, no caso aqui o sbyte.  
             */

            x = 127;

            Console.WriteLine(x);

            x++;
            Console.WriteLine(x);
            /* Com o incremento de x++ o valor passou de 127 para 128, como o valor é superior
             * ao valor permitido pela variável sbyte, aconteceu um erro e o valor 128 passou
             * a ser seu valor oposto que é -128.
             */

            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            double n3 = double.MaxValue;
            decimal n4 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
