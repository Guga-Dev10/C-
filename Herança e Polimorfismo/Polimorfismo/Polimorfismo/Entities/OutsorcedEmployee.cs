namespace Polimorfismo.Entities
{
    class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee()
        {
        }
        public OutsorcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            double payment = Hours * ValuePerHour;
            payment += 1.1 * AdditionalCharge;
            return payment;
        }
    }
}
