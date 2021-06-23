using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solução sem o uso de interface

            Console.WriteLine("Enter rental data:");
            Console.Write("\nCar Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (MM/dd/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (MM/dd/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
