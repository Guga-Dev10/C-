using System;
using System.Globalization;
using System.Collections.Generic;
using Taxes.Entities;
using Taxes.Entities.Enum;

namespace Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InstalledUICulture;

            List<TaxPayer> taxPayersList = new List<TaxPayer>();

            Console.WriteLine("Annual Tax Payers Data: ");
            Console.WriteLine();

            Console.Write("Enter the number of tax payer: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {

                Console.Write("Individual or Company? ");
                TaxPayertype type = Enum.Parse<TaxPayertype>(Console.ReadLine());
                string type1 = type.ToString();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CI);

                if (type1 == "Individual")
                {
                    Console.Write("Health Expenditure: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CI);
                    taxPayersList.Add(new Individual(name, annualIncome, type, healthExpenditure));
                    Console.WriteLine();
                }
                else if (type1 == "Company")
                {
                    Console.Write("Number of Employess: ");
                    int numberOfEmployess = int.Parse(Console.ReadLine());
                    taxPayersList.Add(new Company(name, annualIncome, type, numberOfEmployess));
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Taxes Paid: ");

            double totalIndividualTaxes = 0;
            double totalCompanyTaxes = 0;

            foreach(TaxPayer payer in taxPayersList)
            {
                if(payer is Individual)
                {
                    totalIndividualTaxes += payer.Tax();
                }
                else if (payer is Company)
                {
                    totalCompanyTaxes += payer.Tax();
                }

                Console.WriteLine(
                    payer.Name
                    + ", $"
                    + payer.Tax().ToString("F1", CI));
            }
            Console.WriteLine();
            Console.WriteLine("Total Individual Taxes: $" + totalIndividualTaxes.ToString("F2", CI));
            Console.WriteLine("Total Company Taxes: $" + totalCompanyTaxes.ToString("F2", CI));

            double totalTaxes = totalCompanyTaxes + totalIndividualTaxes;
            Console.WriteLine("Total taxes paid: $"
                + totalTaxes.ToString("F2", CI));
        }
    }
}
