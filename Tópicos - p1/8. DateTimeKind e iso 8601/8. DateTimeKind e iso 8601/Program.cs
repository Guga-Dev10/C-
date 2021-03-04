using System;

namespace _8._DateTimeKind_e_iso_8601 {
    class Program {
        static void Main(string[] args) {


            DateTime t1 = new DateTime(1996, 02, 05, 10, 45, 55, DateTimeKind.Local);
            DateTime t2 = new DateTime(1996, 02, 05, 10, 45, 55, DateTimeKind.Utc);
            DateTime t3 = DateTime.Now;

            Console.WriteLine(t3.ToLocalTime()); // Horário local
            Console.WriteLine(t3.ToUniversalTime()); // Horário Padrão de Londres
            Console.WriteLine(t3);

        }
    }
}
