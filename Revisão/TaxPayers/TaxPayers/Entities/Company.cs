using Taxes.Entities.Enum;

namespace Taxes.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        public Company()
        {
        }
        public Company(string name, double annualIncome, TaxPayertype taxPayertype, int numberOfEmployees)
            : base(name, annualIncome, taxPayertype)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double tax = 0;
            if(NumberOfEmployees > 10)
            {
                tax = AnnualIncome * 0.14;
            }
            else if(NumberOfEmployees <= 10)
            {
                tax = AnnualIncome * 0.16;
            }
            return tax;
        }
    }
}
