namespace Interfaces.Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            double taxvalue = 0;
            if(amount <= 100)
            {
                taxvalue = amount * 0.2; 
            }
            else if(amount > 100)
            {
                taxvalue = amount * 0.15;
            }
            return taxvalue;
        }
    }
}
