using System;

namespace _7._Operacoes_TimeSpan {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            TimeSpan t4 = new TimeSpan(10, 15, 24, 58);
            TimeSpan t5 = new TimeSpan(6, 41, 13, 10);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine("Days = " + t4.Days);

            TimeSpan sum = t4.Add(t5);
            TimeSpan sub = t4.Subtract(t5);
            TimeSpan mult = t4.Multiply(2);
            TimeSpan div = t5.Divide(2);

            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
