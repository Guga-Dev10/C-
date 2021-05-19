using Taxes.Entities.Enum;

namespace Taxes.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditure { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, TaxPayertype taxPayerType, double healthExpenditure)
            : base(name, annualIncome, taxPayerType)
        {
            HealthExpenditure = healthExpenditure;
        }
        public override double Tax()
        {
            double tax = 0;
            if(AnnualIncome < 20000)
            {
                tax = AnnualIncome * 0.15 - HealthExpenditure * 0.5;
            }
            else if(AnnualIncome >= 20000)
            {
                tax = AnnualIncome * 0.25 - HealthExpenditure * 0.5;
            }
            return tax;
        }
    }
}