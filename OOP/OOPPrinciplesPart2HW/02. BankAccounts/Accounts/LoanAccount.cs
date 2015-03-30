namespace BankAccounts.Accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LoanAccount : Accounts, IAccountInformation
    {

        public override decimal GetInterestForPeriod(decimal interestRate, decimal numberOfMonths)
        {
            return base.InterestRate * base.NumberOfMonths;
        }

        public override decimal DepositMoney(decimal balance, decimal moneyToDeposit)
        {
            return base.DepositMoney(balance, moneyToDeposit);
        }
    }
}
