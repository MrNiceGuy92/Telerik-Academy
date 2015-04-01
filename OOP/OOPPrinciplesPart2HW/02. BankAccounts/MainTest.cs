namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainTest
    {
        public static void Main()
        {
            // Deposit account test:
            DepositAccount someAccount = new DepositAccount(new Individuals("James Bond"), 4000M, 1.5M);

            var periodInterestRate = someAccount.CalculatePeriodInterestRate(5, 1.5M);
            var moneyAfterDeposit = someAccount.Deposit(100M);
            var moneyAfterWithdraw = someAccount.Withdraw(500M);

            Console.WriteLine(someAccount);
            Console.WriteLine(string.Format("Period interest rate: {0}", periodInterestRate));
            Console.WriteLine(string.Format("Money after deposit: {0}", moneyAfterDeposit));
            Console.WriteLine(string.Format("Money after withdraw: {0}", moneyAfterWithdraw));

            Console.WriteLine(new string('-', 33));

            // Loan account test:
            LoanAccount anotherAccount = new LoanAccount(new Individuals("Marc Anthony"), 2000M, 2.5M);

            var periodInterestRate1 = anotherAccount.CalculatePeriodInterestRate(5, 2.5M);
            var moneyAfterDeposit1 = anotherAccount.Deposit(50M);
            var moneyAfterWithdraw1 = anotherAccount.Withdraw(300M);

            Console.WriteLine(anotherAccount);
            Console.WriteLine(string.Format("Period interest rate: {0}", periodInterestRate1));
            Console.WriteLine(string.Format("Money after deposit: {0}", moneyAfterDeposit1));
            Console.WriteLine(string.Format("Money after withdraw: {0}", moneyAfterWithdraw1));

            Console.WriteLine(new string('-', 33));
            
            // Mortgage account test:
            MortgageAccount someOtherAccount = new MortgageAccount(new Company("Microsoft"), 30000M, 3.5M);

            var periodInterestRate2 = someOtherAccount.CalculatePeriodInterestRate(14, 3.5M);
            var moneyAfterDeposit2 = someOtherAccount.Deposit(50000M);
            var moneyAfterWithdraw2 = someOtherAccount.Withdraw(400M);

            Console.WriteLine(someOtherAccount);
            Console.WriteLine(string.Format("Period interest rate: {0}", periodInterestRate2));
            Console.WriteLine(string.Format("Money after deposit: {0}", moneyAfterDeposit2));
            Console.WriteLine(string.Format("Money after withdraw: {0}", moneyAfterWithdraw2));
        }
    }
}
