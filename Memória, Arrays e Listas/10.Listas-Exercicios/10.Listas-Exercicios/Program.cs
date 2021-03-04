using System;
using System.Collections.Generic;


namespace _10.Listas_Exercicios {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Employees Add: ");

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++) {
                Console.Write("Add Id = ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Add Name = ");
                string name = Console.ReadLine();
                Console.Write("Add Salary = ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("All employees data = ");

            foreach (Employee obj in employees) {
                Console.WriteLine("Eployee = ");
                Console.WriteLine(obj);
                Console.WriteLine();
            }

            Console.Write("Enter the employee Id that will have salary increase: ");
            int SearchId = int.Parse(Console.ReadLine());

            Employee EmpId = employees.Find(x => x.Id == SearchId);

            if (EmpId != null) {
                Console.Write("Enter the percentage = ");
                double percentage = double.Parse(Console.ReadLine());
                EmpId.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("The Id doesn't exist! ");
            }

            Console.WriteLine();
            foreach (Employee obj in employees) {
                Console.WriteLine("Update employee data: ");
                Console.WriteLine(obj);
                Console.WriteLine();
            }
        }
    }
}
