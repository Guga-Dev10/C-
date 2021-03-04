using System;

namespace _6._Operações_com_DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(1996, 02, 05, 10, 45, 55, 200);

            Console.WriteLine(d);
            Console.WriteLine();
            Console.WriteLine(d.ToLongDateString());
            
            string s1 = d.ToLongTimeString();
            Console.WriteLine(s1);

            string s2 = d.ToShortDateString();
            Console.WriteLine(s2);

            string s3 = d.ToShortTimeString();
            Console.WriteLine(s3);

            Console.WriteLine();
            Console.WriteLine("------------------");

            DateTime d2 = d.AddHours(2);
            Console.WriteLine(d2);

            DateTime d3 = d.AddMinutes(10);
            Console.WriteLine(d3);

            DateTime d4 = d.AddDays(7);
            Console.WriteLine(d4);

            DateTime d5 =  new DateTime();

            TimeSpan T = d5.Subtract(d);

            Console.WriteLine(T);

            Console.WriteLine("--------------");
            Console.WriteLine(d);
            Console.WriteLine("Date = " + d.Date);
            Console.WriteLine("Day = " + d.Day);
            Console.WriteLine("Month = " + d.Month);
            Console.WriteLine("Year = " + d.Year);
            Console.WriteLine("Day of Week = " + d.DayOfWeek);
            Console.WriteLine("Day of Year = " + d.DayOfYear);
            Console.WriteLine("Hour = " + d.Hour);
            Console.WriteLine("Minute = " + d.Minute);
            Console.WriteLine("Second = " + d.Second);
            Console.WriteLine("Millisecond = " + d.Millisecond);
            Console.WriteLine("Kind = " + d.Kind);
            Console.WriteLine("Ticks = " + d.Ticks);
            Console.WriteLine("Time of Day = " + d.TimeOfDay);
        }
    }
}
