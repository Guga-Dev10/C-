using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Euro___Real {
    class Conversor {

        public static double IOF = 0.09;

        public static double ConversorEuroReal(double cotacaoeuro, double quantidadeeuro) {
            double ValorReal = cotacaoeuro * quantidadeeuro;
            ValorReal = ValorReal + (ValorReal * IOF);
            return ValorReal;
        }
    }
}
