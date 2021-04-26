using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override void Withdraw2(double amount)
        {
            base.Withdraw2(amount);
            Balance -= 2.0;
        }
    }
}
