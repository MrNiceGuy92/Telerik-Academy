namespace _09._16.StudentExtractions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tests
    {
        static void Main()
        {
            var studentArray = new List<Student>
            {
                new Student("Michael", "Jordan", 230006, "bulls@abv.bg", "+359212345", new List<int>(){6,5,6}, 3),
                new Student("Scottie", "Pippen", 330005, "rockets@yahoo.com", "+2591234567", new List<int>(){5,5,4}, 2),
                new Student("Dennis", "Rodman", 910006, "pistons@abv.bg", "+35921234567",  new List<int>(){5,4,4}, 1),
                new Student("Rory", "Sparrow", 200005, "knicks@gmail.com", "+1267",  new List<int>(){3,5,4}, 2),
                new Student("Magic", "Johnson", 320006, "lakers@hotmail.com", "+3592124567",  new List<int>(){2,2,2}, 4),
                new Student("Derric", "Rose", 100005, "bulls@hotmail.com", "+3594098567",  new List<int>(){2,6,5}, 2),
            };

            // Test 1A: Extract students that are from group number 2 (with LAMBDA) ---> Problem 9
            Console.WriteLine("Students in group 2 (with LAMBDA):\n");

            Console.WriteLine(string.Join(",", GetStudentsByGroup2LAMBDA(studentArray)));
            Console.WriteLine(new string('-', 30));

            // Test 1B: Extract students that are from group number 2 (with LINQ) ---> Problem 10
            Console.WriteLine("Students in group 2 (with LINQ):\n");

            Console.WriteLine(string.Join(",", GetStudentsByGroup2LINQ(studentArray)));
            Console.WriteLine(new string('-', 30));

            // Test 2: Extract all students that have email in abv.bg ---> Problem 11 
            Console.WriteLine("Students, with email in abv.bg:\n");

            Console.WriteLine(string.Join(",", ExtractByEmail(studentArray)));
            Console.WriteLine(new string('-', 30));

            // Test 3: Extract all students with phones in Sofia ---> Problem 12
            Console.WriteLine("All students with phones in Sofia:\n");

            Console.WriteLine(string.Join(",", ExtractBySofiaPhone(studentArray)));
            Console.WriteLine(new string('-', 30));

            // Test 4: Select all students that have at least one mark Excellent (6) into a new anonymous class 
            // that has properties – FullName and Marks.  ---> Problem 13
            var extractedByExcellent =
               from studs in studentArray
               where studs.Marks.Contains(6)
               select new { FullName = studs.FirstName + " " + studs.LastName, Marks = string.Join(",", studs.Marks) };

            Console.WriteLine("All students who have an excellent mark:\n");
            foreach (var item in extractedByExcellent)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
        }

        private static IEnumerable<Student> GetStudentsByGroup2LAMBDA(List<Student> studentArray)
        {
            var result = studentArray
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList();

            return result;
        }

        private static IEnumerable<Student> GetStudentsByGroup2LINQ(List<Student> studentArray)
        {
            var result =
                from studs in studentArray
                where studs.GroupNumber == 2
                orderby studs.FirstName
                select studs;

            return result;
        }

        private static IEnumerable<Student> ExtractByEmail(List<Student> studentArray)
        {
            var result = studentArray
                .Where(x => x.Email.Contains("@abv.bg"))
                .ToList();

            return result;
        }

        private static IEnumerable<Student> ExtractBySofiaPhone(List<Student> studentArray)
        {
            var result = studentArray
                .Where(x => x.Tel.Contains("+3592"))
                .ToList();

            return result;
        }
    }
}

