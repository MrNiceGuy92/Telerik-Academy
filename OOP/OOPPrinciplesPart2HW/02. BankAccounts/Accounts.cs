namespace BankAccounts
{    
    using System;
    using System.Text;

    public abstract class Accounts : IWithdraw
    {
        // Fields
        private decimal balance;
        private decimal interestRate;
        
        // Base constructor
        public Accounts(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        // Properties
        public decimal Balance 
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be negative.");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate 
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative.");
                }

                this.interestRate = value;
            }
        }

        public Customer Customer { get; set; }

        // Methods to be overridden in derived classes
        public virtual decimal Deposit(decimal amount)
        {
            return this.Balance + amount;
        }

        public virtual decimal CalculatePeriodInterestRate(int numberOfMonths, decimal interestRate)
        {
            return (decimal)numberOfMonths * interestRate;
        }

        // Method inherited from IWithdraw interface
        public virtual decimal Withdraw(decimal amount)
        {
            return this.balance - amount;
        }

        // Override .ToString() method
        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("Account type: {0}", this.GetType().Name));
            result.AppendLine(string.Format("Customer Name: {0}", this.Customer.Name));
            result.AppendLine(string.Format("Interest rate: {0}", this.InterestRate));
            result.AppendLine(string.Format("Balance: {0}", this.Balance));

            return result.ToString();
        }
    }
}
