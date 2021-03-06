using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerExercicio.Entities
{
    class HourContract
    {
        // Atributos da Classe
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        // Construtores da Classe
        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // Métodos da Classe

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
