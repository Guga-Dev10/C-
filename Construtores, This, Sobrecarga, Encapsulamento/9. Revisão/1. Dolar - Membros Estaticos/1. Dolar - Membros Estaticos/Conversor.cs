using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Dolar___Membros_Estaticos {
    class Conversor {

        public static double IOF = 0.06;
        
        public static double ConversorDolarParaReal(double dolarpreco, double dolarquantidade) {
            double valorReal = dolarpreco * dolarquantidade;
            valorReal = valorReal + valorReal * IOF;
            return valorReal;
        }
    }
}
