using System;
using System.Collections.Generic;
using System.Text;

namespace _8._4_Revisao {
    class ConversorDeMoeda {


        public static double CotacaoDolar = 3.1;
        public static double IOF = 0.06;
        public double Dolar;


        public double ConversorDolarParaReal() {
            double real = Dolar * CotacaoDolar;
                   real = real + (real * IOF);
            return real;
        }

    }
}
