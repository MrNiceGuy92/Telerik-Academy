namespace BankAccounts.Accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Accounts : IAccountInformation
    {
        private string customerName;
        private decimal balance;
        private decimal interestRate;
        private int numberOfMonths;
          
        public string CustomerName
        {
            get
            {
                return this.customerName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }

                this.customerName = value;
            }
        }

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
                if (value < 0 || value > 5.4M)
                {
                    throw new ArgumentOutOfRangeException("Rate is too high or too low.");
                }

                this.interestRate = value;
            }
        }

        public int NumberOfMonths
        {
            get
            {
                return this.numberOfMonths;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of months must be positive.");
                }

                this.numberOfMonths = value;
            }
        }

        public abstract decimal GetInterestForPeriod(decimal interestRate, decimal numberOfMonths);
       
        public virtual decimal WithdrawMoney(decimal balance, decimal moneyToWithdraw)
        {
            return this.Balance - moneyToWithdraw;
        }

        public virtual decimal DepositMoney(decimal balance, decimal moneyToDeposit)
        {
            return this.Balance + moneyToDeposit;
        }

    }
}
