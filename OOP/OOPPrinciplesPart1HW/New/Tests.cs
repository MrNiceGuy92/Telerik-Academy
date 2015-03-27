namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tests
    {
        public static void Main()
        {
            var studentList = new List<Student>()
            {
                new Student("Abraham", "Lincoln", 4.6),
                new Student("George", "Washington", 5.6),
                new Student("Ulysses S.", "Grant", 3.4),
                new Student("George", "Bush", 2.2),
                new Student("John F.", "Kennedy", 6.0),
                new Student("Thomas", "Jefferson", 5.8),
                new Student("Andrew", "Johnson", 3.8),
                new Student("Barack", "Obama", 2.1),
                new Student("Theodore", "Roosevelt", 5.5),
                new Student("Richard", "Nixon", 4.7),
            };

            var workerList = new List<Worker>()
            {
                new Worker("Georgi", "Asparuhov", 1234.5M, 17.5),
                new Worker("Krassimir", "Bulukov", 3234.5M, 12.6),
                new Worker("Stiliyan", "Petrov", 4214.8M, 10.9),
                new Worker("Martin", "Petrov", 34.5M, 2.6),
                new Worker("Dimitur", "Penev", 324.5M, 10.1),
                new Worker("Nasko", "Sirakov", 84.2M, 11.1),
                new Worker("Hristo", "Stoichkov", 922.0M, 19.4),
                new Worker("Trifon", "Ivanov", 1000.9M, 9.6),
                new Worker("Hristo", "Bonev", 794.7M, 8.8),
            };

            // Sort students by grade in ascending order
            Console.WriteLine("Sorted students by grade in ascending order:\n");

            Console.WriteLine(string.Join(string.Empty, SortByGrade(studentList)));

            Console.WriteLine(new string('-', 30));

            // Sort workers by money per hour in descending order
            Console.WriteLine("Sort workers by money per hour in descending order:\n");

            Console.WriteLine(string.Join(string.Empty, WorkerMoney(workerList)));
            Console.WriteLine(new string('-', 30));

            // Merge the lists and sort them by first name and last name
            Console.WriteLine("Merge lists and sort them by first name and last name:\n");

            // Create merged list
            var fullList = new List<AbstHuman>(studentList.Count + workerList.Count);

            fullList.AddRange(studentList);
            fullList.AddRange(workerList);

            Console.WriteLine(string.Join(string.Empty, SortByFirstAndLastName(fullList))); 
        }

        private static IEnumerable<Student> SortByGrade(List<Student> studentList)
        {
            var result = studentList
                .OrderBy(x => x.Grade)
                .ToList();

            return result;
        }

        private static IEnumerable<Worker> WorkerMoney(List<Worker> workerList)
        {
            var result = workerList
                .OrderByDescending(x => x.MoneyPerHour())
                .ToList();

            return result;
        }

        private static IEnumerable<AbstHuman> SortByFirstAndLastName(List<AbstHuman> fullList)
        {
            var sortByName = fullList
               .OrderBy(x => x.FirstName)
               .ThenBy(x => x.LastName)
               .ToList();

            return sortByName;
        }
    }
}
