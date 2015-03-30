namespace BankAccounts.Accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAccountInformation
    {
        string CustomerName { get; set; }

        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        int NumberOfMonths { get; set; }

        decimal GetInterestForPeriod(decimal interestRate, decimal numberOfMonths);
    }
}
