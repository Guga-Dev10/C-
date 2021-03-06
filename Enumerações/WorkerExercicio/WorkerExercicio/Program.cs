using System;
using System.Globalization;
using System.Collections.Generic;
using WorkerExercicio.Entities;
using WorkerExercicio.Entities.Enums;


namespace WorkerExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter department's name = ");
            string deptName = Console.ReadLine();
            
            Console.WriteLine();
            Console.Write("Enter Worker Data:");
            Console.WriteLine();

            Console.Write("Name = ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/Midlevel/Senior) = ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); // Conversão String-Enum
            Console.Write("Base Salary = ");
            double baseSalary = double.Parse(Console.ReadLine(), CI);

            Department dept = new Department(deptName);
            Worker worker = new Worker(workerName, level, baseSalary, dept);

            Console.WriteLine();
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (MM/DD/YYYY) = ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour = ");
                double valuePerHour = double.Parse(Console.ReadLine(), CI);
                Console.Write("Duration (hours) = ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY) = ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine();
            Console.WriteLine("Worker Name = " + worker.WorkerName);
            Console.WriteLine("Department = " + worker.Department.DepartmentName);
            Console.WriteLine("Income for " + monthAndYear + ": $" + worker.Income(year, month));
        }
    }
}
