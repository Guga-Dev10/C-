using System;

namespace _5._TimeSpan {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0, 1, 25); // hora, minuto, segundo
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(1, 5, 14, 28); // dia, hora, minuto, segundo
            TimeSpan t4 = new TimeSpan(1, 5, 14, 28, 140); // dia, hora, minuto, segundo, milissegundo

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine();

            TimeSpan t5 = TimeSpan.FromDays(2);
            TimeSpan t6 = TimeSpan.FromHours(2);
            TimeSpan t7 = TimeSpan.FromMinutes(2);
            TimeSpan t8 = TimeSpan.FromSeconds(2);
            TimeSpan t9 = TimeSpan.FromMilliseconds(2);

            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
        }
    }
}
