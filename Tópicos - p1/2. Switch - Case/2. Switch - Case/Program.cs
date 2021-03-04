using System;

namespace _2._Switch___Case {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            string Day;

            switch (N) {
                case 1:
                    Day = "Sunday";
                    break;
                case 2:
                    Day = "Monday";
                    break;
                case 3:
                    Day = "Tuesday";
                    break;
                case 4:
                    Day = "Wednesday";
                    break;
                case 5:
                    Day = "Thursday";
                    break;
                case 6:
                    Day = "Friday";
                    break;
                case 7:
                    Day = "Saturnday";
                    break;
                default:
                    Day = "Invalid Value";
                    break;
            }

            Console.WriteLine($"Day = {Day}");
        }
    }
}
