using System;

namespace _3._Condicional_Ternária {
    class Program {
        static void Main(string[] args) {  
            
            // ( condição ) ? valor_se_verdadeiro : valor_se_falso

            double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);
            /*
             * double desconto;
            if (preco < 20.0) {
            desconto = preco * 0.1;
            }
            else {
            desconto = preco * 0.05;
            }
            */
        }
    }
}
