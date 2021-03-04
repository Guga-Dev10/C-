using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Params {
    class Calculator {

        public static double Sum(params int[] Numbers) {
            double sum = 0;
            for (int i = 0; i < Numbers.Length; i++) {
                sum += Numbers[i];
            }
            return sum;
        }
    }
}
