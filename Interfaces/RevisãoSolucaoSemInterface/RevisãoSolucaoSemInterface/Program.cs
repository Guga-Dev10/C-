using System;
using System.Globalization;

namespace RevisãoSolucaoSemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup MM/dd/yyyy HH:mm = ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return MM/dd/yyyy HH:mm = ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);

        }
    }
}
