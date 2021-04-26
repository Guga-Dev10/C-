using System;
using System.Globalization;
using System.Collections.Generic;
using TaxesExercise.Entities;

namespace TaxesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Anual Taxes Income");
            Console.WriteLine();

            Console.Write("Enter the number of tax payer: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double totalIndividualTaxes = 0;
            double totalCompanyTaxes = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the #{i} tax payer data:");
                Console.Write("Individual or Company (i/c)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CI);

                if(resp == 'i')
                {
                    Console.Write("Health Expenditure: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CI);
                    list.Add(new Individual(name, anualIncome, healthExpenditure));
                    Console.WriteLine();
                }
                else if(resp == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                    Console.WriteLine();
                }
            }
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer payer in list)
            {
                if(payer is Individual)
                {
                    totalIndividualTaxes += payer.Tax();
                }
                else if(payer is Company)
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