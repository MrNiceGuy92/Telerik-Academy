namespace BankAccounts
{
    public class DepositAccount : Accounts, IWithdraw
    {
        // Constructor
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Deposit method inherited from base class
        public override decimal Deposit(decimal amount)
        {
            return base.Deposit(amount);
        }

        // Withdraw method inherited from interface (and base class)
        public override decimal Withdraw(decimal amount)
        {
            return base.Withdraw(amount);
        }

        // CalculatePeriodInterestRate method inherited from base class
        public override decimal CalculatePeriodInterestRate(int numberOfMonths, decimal interestRate)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
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
