using System;
using System.Globalization;

namespace _10.Listas_Exercicios {
    class Employee {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee() {

        }
        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage) {
            Salary = Salary + Salary * (percentage / 100);
        }

        public override string ToString() {
            return "Id = "
                + Id
                + "\n"
                + "Name = "
                + Name
                + "\n"
                + "Salary = $ "
                + Salary.ToString("F2", CI);
        }
    }
}
