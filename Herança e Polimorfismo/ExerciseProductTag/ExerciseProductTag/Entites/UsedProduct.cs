using System;

namespace ExerciseProductTag.Entites
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedDate)
            : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string ProductTag()
        {
            return Name + " (used) = $" + Price 
                + " (Manufactured Date = " + ManufacturedDate.ToString("MM/dd/yyyy") + ")";
        }
    }
}
