namespace BankAccounts
{
    using System;

    public class LoanAccount : Accounts, IWithdraw
    {
        // Constructor
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
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
                numberOfMonths = Math.Max(0, numberOfMonths - 3); // (decimal)numberOfMonths * interestRate formula will change appropriately
            }
            else if (this.Customer is Company)
            {
                numberOfMonths = Math.Max(0, numberOfMonths - 2); // (decimal)numberOfMonths * interestRate formula will change appropriately
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
