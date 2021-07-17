namespace Membros_Estaticos_Exercicio.Entities
{
    class ConversorDeMoedas
    {
        public static double Conversor(double cotacaoDolar, double qteDolar)
        {
            double IOF = 0.06;
            double qte = cotacaoDolar + cotacaoDolar * IOF;
            qte *= qteDolar;
            return qte;
        }
    }
}
