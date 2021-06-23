using System.Globalization;

namespace Interfaces.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        
        // Construtores
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        // Propriedade calculada

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        CultureInfo CI = CultureInfo.InvariantCulture;

        // Implementação do ToString
        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("F2", CI)
                + "\nTax: "
                + Tax.ToString("F2", CI)
                + "\nTotal Payment: "
                + TotalPayment.ToString("F2", CI);
        }
    }
}
