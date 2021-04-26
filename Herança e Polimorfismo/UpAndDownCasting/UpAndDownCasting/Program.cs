using System;
using UpAndDownCasting.Entities;

namespace UpAndDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      O 'Upcasting' é um casting da subclasse para a superclasse
             *      O 'Downcasting' é um casting da Superclasse para a subclasse. Possui o 
             *  uso de 'is' e 'as'.
             */

            Account acc = new Account(1500, "Fabio", 2000);
            BusinessAccount bacc = new BusinessAccount(1400, "Ronaldo", 1500, 400);

            //      UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1200, "Alex", 1400, 250);
            Account scc1 = new SavingsAccount(100, "Maira", 1000, 0.01);

            /*  Um objeto de uma superclasse recebe narutalmente qualquer objeto que esteja 
             *  ligado a qualquer uma de suas subclasses, pois uma subclasse pertence e é parte 
             *  de uma superclasse. Porém, os métodos das subclasses não podem ser usados em
             *  objetos da superclasses, pois o compilador não reconhece o tipo da instanciação,
             *  somente da declaração da variável.
             *  Ex:. acc2.Loan() = Erro, pois o método 'Loan' é um método da subclasse 
             */


            //  DOWNCASTING
            BusinessAccount bacc1 = (BusinessAccount)acc2;
            // O compilador não reconhece o 'acc2' como um BusinessAccount, por isso o Casting foi usado

            // BusinessAccount bacc2 = (BusinessAccount)acc; = erro
            // O compilador não permite uma atribuição de uma superclasse para uma subclasse

            /*      Embora os tipos das variáveis fossem o mesmo 'Account' o compilador não permite
             *      a conversão por causa do tipo em que as variáveis foram instanciadas, por exemplo
             *      em 'Business' ou 'Savings'.
             */

            /*      O Downcasting é uma operação de risco, pois o compilador muitas vezes não 
             * consegue identificar alguns tipos de erros de conversão e 'aceita' sem nenhum aviso
             * no código, porém quando o código for compilado o programa não irá funcionar pois 
             * o 'CASTING' não foi feito com sucesso.
             *      Um exemplo de erro é entre castings de subclasses: bacc2(Business) e sacc1(Savings)
             *      bacc2 = (BusinessAccount)sacc1; 
             */

            // Para verificar qual o tipo da variável a ser usada em Casting é necessário usar a palavra 'Is'

            if (scc1 is BusinessAccount)
            {
                BusinessAccount bacc5 = (BusinessAccount)scc1;
                Console.WriteLine("Loan");
                //o compilador não acusa erro, porém o scc1 não é um objeto de BusinessAccount
            }
            if (scc1 is SavingsAccount)
            {
                SavingsAccount bacc5 = (SavingsAccount)scc1;
                Console.WriteLine("Update!");
                // o scc1 é um objeto de savings
            }

            // sintaxe alternativa de casting usando 'as'

            if (scc1 is BusinessAccount)
            {
                BusinessAccount bacc5 = scc1 as BusinessAccount;
                Console.WriteLine("Loan");
                //o compilador não acusa erro, porém o scc1 não é um objeto de BusinessAccount
            }
            if (scc1 is SavingsAccount)
            {
                SavingsAccount bacc5 = scc1 as SavingsAccount;
                Console.WriteLine("Update!");
                // o scc1 é um objeto de savings
            }
        }
    }
}
