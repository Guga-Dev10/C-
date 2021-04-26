using ClassesEMetodosSelados.Entities;
using System;

namespace ClassesEMetodosSelados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pra que usar o método 'sealed'? 
             * 
             * Por segurança e performance!!
             * 
             *       Dependendo das regras do negócio do cliente, convém garantir que os métodos de
             * uma classe não possa ser herdada ou sobreposto em outras subclasses.
             * 
             *      Geralmente convém selar métodos sobrepostos, pois múltiplas sobreposições
             * trazem inconsistências para o código. 
             * 
             *      Atributos de tipos selados também trazem mais performance ao serem executados.
             * se a classe ou o método estiverem selados, o compilador não precisará olhar em outras
             * subclasses procurando pelos métodos sobrepostos, caso contrário teria que percorrer todo
             * o código procurando pelos métodos sobrepostos e executando suas possíveis alterações.
             * 
             *      O código selado também impede que um programador possa alterar a funcionalidade
             * de um método em uma subclasse, trazendo muitos possíveis prejuízos para o código.
             */
        }
    }
}
