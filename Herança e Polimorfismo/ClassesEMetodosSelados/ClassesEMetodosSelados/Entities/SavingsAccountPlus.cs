using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEMetodosSelados.Entities
{
    class SavingsAccountPlus : SavingsAccount; //erro quando estiver um comando 'sealed' na classe mãe
    {
        /*      O comando 'sealed' na subclasse SavingsAccount está impedindo qualquer tipo
         *   de herença entre as classes e uma possível sublclasse
         */

        public override void Withdraw2(double amount)
        {
            base.Withdraw(amount);
         
         /* Também está selado pelo comando 'sealed', impedindo que a classe fliha possa
          * usar o método da classe mãe.
          * 
          * Quando um método de sobrescrita é selado, ele não deixa mais nenhuma subclasse 
          * reutilizá-lo, com isso traz mais segurança para o código e não o deixa com 
          * inconsistências.
         */
        }

       
    }
}
