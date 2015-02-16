//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager 
//has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.



using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            Console.Write("Input company Name: ");
            string compName = Console.ReadLine();
            
            Console.Write("Input company Address: ");
            string compAddress = Console.ReadLine();
            
            Console.Write("Input phone number: ");
            string phoneNum = Console.ReadLine();
            
            Console.Write("Input fax number: ");
            string faxNum = Console.ReadLine();

            Console.Write("Input company website: ");
            string compWeb = Console.ReadLine();
            
            Console.Write("Input manager first name: ");
            string managerFirstName = Console.ReadLine();
            
            Console.Write("Input manager last name: ");
            string managerLastName = Console.ReadLine();
            
            Console.Write("Input manager age: ");
            int managerAge = Int32.Parse(Console.ReadLine());
            
            Console.Write("Input manager phone number: ");
            string managerPhoneNumber = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Company Name: {0}", compName);
            Console.WriteLine("Company Address: {0}", compAddress);
            Console.WriteLine("Phone number: {0}", phoneNum);
            Console.WriteLine("Fax number: {0}", faxNum);
            Console.WriteLine("Company Web Site: {0}", compWeb);
            Console.WriteLine("Manager first name: {0}", managerFirstName);
            Console.WriteLine("Manager last name: {0}", managerLastName);
            Console.WriteLine("Manager age: {0}", managerAge);
            Console.WriteLine("Manager phone number: {0}", managerPhoneNumber);
        }
    }
}
