using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            Console.Write("First name of employee: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name of employee: ");
            string lastName = Console.ReadLine();
            Console.Write("Age of employee: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.Write("Gender of employee: ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Personal ID number of employee: ");
            ulong IDNumber = uint.Parse(Console.ReadLine());
            Console.Write("Unique employee number: ");
            ulong employeeNum = ulong.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", firstName, lastName, age, gender, IDNumber, employeeNum);

        }
    }
}
