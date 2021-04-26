using System;
using System.Globalization;
using System.Collections.Generic;
using Polimorfismo.Entities;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Employee > list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the #{i} employee data:");
                Console.Write("Outsorced Employee? (y/n): ");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 'y')
                {
                    resp = 'Y';
                }
                else if (resp == 'n')
                {
                    resp = 'N';
                }
                Console.Write("Name = ");
                string name = Console.ReadLine();
                Console.Write("Hours = ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour = ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'Y')
                {
                    Console.Write("Additional charge = ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                    Console.WriteLine();
                }
                else if(resp == 'N')
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments:");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " = $" + emp.Payment());
            }
        }
    }
}
