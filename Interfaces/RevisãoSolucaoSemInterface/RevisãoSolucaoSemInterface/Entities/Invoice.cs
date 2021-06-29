namespace RevisãoSolucaoSemInterface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }
        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment
                + "\nTax: "
                + Tax
                + "\nTotalPayment: "
                + TotalPayment.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
