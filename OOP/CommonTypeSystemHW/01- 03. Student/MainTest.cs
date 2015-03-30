namespace Student
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    public class MainTest 
    {
        public static void Main()
        {
            Student[] students = new Student[] // Style cop layout
            {
                new Student(
                    "Pencho", "Penchev", "Penchev", 1234543, "02432183206", "Serdika str.", "pencho@abv.bg", "Discrete Mathematics", Specialties.Mathematics, Faculties.MathematicsFaculty, Universities.CalTech),
                new Student(
                    "Nikolay", "Atanasov", "Kostov", 2129218, "0243568797", "Moskva str.", "niki@telerik.com", "AI", Specialties.ComputerScience, Faculties.ComputerScienceFaculty, Universities.MIT),
                new Student(
                    "Nikolay", "Andonov", "Kostov", 1469013, "0359621959", "Bqla str.", "kostov@telerik.com", "AI", Specialties.ComputerScience, Faculties.ComputerScienceFaculty, Universities.MIT),
                new Student(
                    "Elena", "Anatoliq", "Osipova", 1097593, "01985160392", "Pirin str.", "elena@hotmail.com", "Commerce and Informatics", Specialties.Informatics, Faculties.InformaticsFaculty, Universities.UCLA),
            };

            // .ToString() Test:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(".ToString() Test:\n");

            Console.ResetColor();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 30));

            // .Equals() Test:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(".Equals() Test:\n");

            Console.ResetColor();
            Console.WriteLine(students[0].Equals(students[1]));
            Console.WriteLine(students[1].Equals(students[2]));
            Console.WriteLine(new string('-', 30));

            // .GetHashCode() Test:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(".GetHashCode() Test:\n");

            Console.ResetColor();

            foreach (var student in students)
            {
                Console.WriteLine(student.GetHashCode());
            }

            Console.WriteLine(new string('-', 30));

            // == Operator Test:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("== Operator Test:\n");

            Console.ResetColor();

            Console.WriteLine(students[0] == students[1]);
            Console.WriteLine(students[1] == students[2]);
            Console.WriteLine(new string('-', 30));

            // != Operator Test:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!= Operator Test:\n");

            Console.ResetColor();

            Console.WriteLine(students[0] != students[1]);
            Console.WriteLine(students[1] != students[2]);
            Console.WriteLine(new string('-', 30));

            // Creating a clone of students
            object cloned = students.Clone();

            // .CompareTo() Test
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(".CompareTo() 'Test':\n");

            Console.ResetColor();

            // Comparing first and second student
            // If = 1 (i.e. > 0) print students in order
            if(students[0].CompareTo(students[1]) > 0) 
            {
                Console.WriteLine(students[1]);
                Console.WriteLine(students[0]);
            }
        }
    }
}
