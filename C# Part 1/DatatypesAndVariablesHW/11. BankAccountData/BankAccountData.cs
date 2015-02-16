using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Balance: ");
            int balance = Int32.Parse(Console.ReadLine());
            
            Console.Write("Bank name: ");
            string bankName = Console.ReadLine();

            Console.Write("IBAN: ");
            string iban = Console.ReadLine();

            Console.Write("First Card number: ");
            ulong firstCreditCard= ulong.Parse(Console.ReadLine());

            Console.Write("Second Card number: ");
            ulong secondCreditCard = ulong.Parse(Console.ReadLine());

            Console.Write("Third Card number: ");
            ulong thirdCreditCard = ulong.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", firstName, middleName, lastName, balance, 
                iban, firstCreditCard, secondCreditCard, thirdCreditCard);
        }
    }
}
