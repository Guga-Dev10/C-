using Taxes.Entities.Enum;

namespace Taxes.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public TaxPayertype TaxPayertype { get; set; }
        
        public TaxPayer()
        {
        }
         protected TaxPayer(string name, double annualIncome, TaxPayertype taxPayertype)
        {
            Name = name;
            AnnualIncome = annualIncome;
            TaxPayertype = taxPayertype;
        }

        abstract public double Tax();
    }
}