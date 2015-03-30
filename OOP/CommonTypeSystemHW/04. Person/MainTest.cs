namespace Person
{
    using System;
    using System.Collections.Generic;

    public class MainTest
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Check WITHOUT specified age:\n");

            Console.ResetColor();
            var somePerson = new Person("Michael");

            Console.WriteLine(somePerson);

            Console.WriteLine(new string('-', 30));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Check WITH specified age:\n");

            Console.ResetColor();

            var anotherPerson = new Person("Alejandro", 23);

            Console.WriteLine(anotherPerson);
        }
    }
}
