using System; 

namespace Membros_Estaticos.Entities
{
    class Calculadora
    {
        /* colocando um comando static nas funções permite que eles possam ser chamados 
         * em outras partes do código sem precisar de instânciação 
         */

        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
