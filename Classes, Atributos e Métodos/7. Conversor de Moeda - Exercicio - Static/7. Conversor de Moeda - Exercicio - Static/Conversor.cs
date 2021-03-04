using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _7._Conversor_de_Moeda___Exercicio___Static {
    class Conversor {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public static double Calculo(double dolar, double quantidade, double IOF) {
            double valordolar = (dolar * quantidade);
                   valordolar = valordolar + valordolar * IOF / 100;
            return valordolar;
        }
    }
}
