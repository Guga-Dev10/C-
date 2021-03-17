using System;
<<<<<<< HEAD
using System.Globalization;
using System.Collections.Generic;
using WorkerRevisao.Entities.Enums;
using WorkerRevisao.Entities;
=======
>>>>>>> de15addf3a25311329912e15a37ff566790ed6ae

namespace WorkerRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Worker's Data");
            Console.WriteLine();

            Console.Write("Enter department's name = ");
            string deptName = Console.ReadLine();
            Console.Write("Name = ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior) = ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary = ");
            double baseSalary = double.Parse(Console.ReadLine(), CI);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine();
            Console.Write("How many contrats to this worker? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (MM/DD/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CI);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Enter with month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine();
            Console.WriteLine("Name = " + worker.Name);
            Console.WriteLine("Department = " + worker.Department.Name);
            Console.WriteLine("Income = " + monthAndYear + ": " + worker.Income(year, month));


=======
            Console.WriteLine("Hello World!");
>>>>>>> de15addf3a25311329912e15a37ff566790ed6ae
        }
    }
}
