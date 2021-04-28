using System;
using Exceções_Personalizadas.Entities;

namespace Exceções_Personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Versão 1 - O programa irá simular um hotel, com datas de checkin e checkout

            Console.WriteLine("HOTEL CALIFORNICATION");

            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the check-In Date (MM/dd/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the check-Out Date (MM/dd/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());


            if (checkout < checkin)
            {
                Console.WriteLine("Error in reservation! Check-In date must be after the check-Out date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation = " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (MM/dd/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (MM/dd/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates " +
                        "for update must be future dates from now " + DateTime.Now.ToString("MM/dd/yyyy"));
                }
                else if (checkout <= checkin)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
