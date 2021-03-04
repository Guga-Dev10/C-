using System;

namespace _5._Ref_e_Out {
    class Program {
        static void Main(string[] args) {

            int a = 30;
            Calculadora.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int triple;
            Calculadora.Triple2(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
