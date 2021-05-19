using System;
using System.Globalization;

namespace Revision.Entities
{
    public class CostumerData
    {
        public string Name { get;  set; }
        public int Years { get; set; }
        public double Price {get; set; }

        public CostumerData()
        {
        }
        public CostumerData(string name, int years, double price)
        {
            Name = name;
            Years = years;
            Price = price;
        }
        public override string ToString(){
            return 
            "Name = "
            + Name
            + ", Age = "
            + Years
            + ", Price = $"
            + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
} 