using System.Collections.Generic;
using WorkerExercicio.Entities.Enums;

namespace WorkerExercicio.Entities
{
    class Worker
    {
        // Atributos da Classe

        public string WorkerName { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Composição
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        // Composição + Lista
        // Já se iniciou a instânciação para que a Lista não seja nula

        // Construtores

        public Worker() { }

        // Geralmente não se instancia construtores com listas
        public Worker(string name, 
            WorkerLevel level, 
            double baseSalary, 
            Department department
            )
        {
            WorkerName = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // Métodos

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
