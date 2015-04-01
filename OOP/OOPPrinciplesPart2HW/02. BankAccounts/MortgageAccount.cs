namespace BankAccounts
{
    using System;

    public class MortgageAccount : Accounts, IWithdraw
    {
        // Constructor
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Overridden Deposit method
        public override decimal Deposit(decimal amount)
        {
            return base.Deposit(amount);
        }

        // Overridden Withdraw method
        public override decimal Withdraw(decimal amount)
        {
            return base.Withdraw(amount);
        }

        // Overridden CalculatePeriodInterestRate method
        public override decimal CalculatePeriodInterestRate(int numberOfMonths, decimal interestRate)
        {
            if (this.Customer is Individuals)
            {
                numberOfMonths = Math.Max(0, numberOfMonths - 6);
            }
            else if (this.Customer is Company)
            {
                if (numberOfMonths >= 12)
                {
                   var result = base.CalculatePeriodInterestRate(12, interestRate / 2);

                   numberOfMonths -= 12;
                   return base.CalculatePeriodInterestRate(numberOfMonths, interestRate) + result;
                }
            }

            return base.CalculatePeriodInterestRate(numberOfMonths, interestRate);
        }

        // .ToString() method
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
