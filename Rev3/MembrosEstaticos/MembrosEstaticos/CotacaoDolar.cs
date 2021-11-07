namespace MembrosEstaticos
{
    class CotacaoDolar
    {
        public static double IOF = 6.0;
        public static double Calculadora(double dolar, double quantidade)
        {
            double valorDaCotacao = dolar * quantidade;
            valorDaCotacao += valorDaCotacao * (IOF / 100);
            return valorDaCotacao;
        }
    }
}
