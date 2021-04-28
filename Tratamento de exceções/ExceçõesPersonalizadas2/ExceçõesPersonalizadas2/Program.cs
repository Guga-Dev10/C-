using System;
using System.Globalization;
using ExceçõesPersonalizadas2.Entities;
using ExceçõesPersonalizadas2.Entities.Exception;

namespace ExceçõesPersonalizadas2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Versão 2 - O programa irá simular um hotel, com datas de checkin e checkout

            try
            {
                Console.WriteLine("HOTEL CALIFORNICATION");

                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Enter the check-In Date (MM/dd/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter the check-Out Date (MM/dd/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (MM//dd/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (MM/dd/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
