namespace _03_04_05.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tests
    {
        public static void Main()
        {
            Student[] studentDirectory = new Student[]
            {
                new Student("Elena", "Borisova", 20),
                new Student("Zoro", "Stoyanov", 17),
                new Student("Stamat", "Ognqnov", 24),
                new Student("Penka", "Tordanova", 13),
            };

            // Test 1: First before last (Problem 3)
            Console.WriteLine("First before last test:\n");

            var result = string.Join(",", FirstBeforeLast(studentDirectory));
            Console.WriteLine(result);
            Console.WriteLine(new string('-', 30));

            // Test2: Age Range (Problem 4)
            Console.WriteLine("Age range test:\n");

            var secondResult = string.Join(", ", AgeRange(studentDirectory));
            Console.WriteLine(secondResult);
            Console.WriteLine(new string('-', 30));

            // Test 3A: Order Students (with LAMBDA) Problem 5
            Console.WriteLine("Order Students (with LAMBDA) test:\n");

            var thirdResult = string.Join(", ", OrderStudentsLAMBDA(studentDirectory));
            Console.WriteLine(thirdResult);
            Console.WriteLine(new string('-', 30));

            // Test 3B: Order Students (with LINQ) Problem 5
            Console.WriteLine("Order Students (with LINQ) test:\n");

            var fourthResult = string.Join(", ", OrderStudentsLINQ(studentDirectory));
            Console.WriteLine(fourthResult);
            Console.WriteLine(new string('-', 30));
        }

        private static IEnumerable<Student> FirstBeforeLast(Student[] studentDirectory)
        {
            var result = 
                from stud in studentDirectory
                where stud.FirstName.CompareTo(stud.LastName) < 0
                select stud;

            return result;
        }

        private static IEnumerable<Student> AgeRange(Student[] studentDirectory)
        {
            var result =
                from stud in studentDirectory
                where stud.Age >= 18 && stud.Age <= 24
                select stud;

            return result;
        }

        private static IEnumerable<Student> OrderStudentsLAMBDA(Student[] studentDirectory)
        {
            var result = studentDirectory
               .OrderBy(x => x.FirstName)
               .ThenBy(x => x.LastName)
               .Reverse();

            return result;
        }

        private static IEnumerable<Student> OrderStudentsLINQ(Student[] studentDirectory)
        {
            var result =
                from stud in studentDirectory
                orderby stud.FirstName descending
                select stud;

            return result;
        }
    }
}
