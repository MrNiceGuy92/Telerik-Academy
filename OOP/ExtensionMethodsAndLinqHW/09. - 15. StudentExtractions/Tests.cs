namespace _09._15.StudentExtractions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tests
    {
        public static void Main()
        {
            var studentList = new List<Student>
            {
                new Student("Michael", "Jordan", 230006, "bulls@abv.bg", "+359212345", new List<int>(){6,5,6}, 3),
                new Student("Scottie", "Pippen", 330005, "rockets@yahoo.com", "+2591234567", new List<int>(){5,5,4}, 2),
                new Student("Dennis", "Rodman", 910006, "pistons@abv.bg", "+35921234567",  new List<int>(){5,4,4}, 1),
                new Student("Rory", "Sparrow", 200005, "knicks@gmail.com", "+1267",  new List<int>(){3,5,4}, 2),
                new Student("Magic", "Johnson", 320006, "lakers@hotmail.com", "+3592124567",  new List<int>(){2,2,6}, 4),
                new Student("Derric", "Rose", 100005, "bulls@hotmail.com", "+3594098567",  new List<int>(){2,6,5}, 2),
            };

            // Test 1A: Extract students that are from group number 2 (with LAMBDA) ---> Problem 9
            Console.WriteLine("Students in group 2 (with LAMBDA):\n");

            Console.WriteLine(string.Join(",", GetStudentsByGroup2LAMBDA(studentList)));
            Console.WriteLine(new string('-', 30));

            // Test 1B: Extract students that are from group number 2 (with LINQ) ---> Problem 10
            Console.WriteLine("Students in group 2 (with LINQ):\n");

            Console.WriteLine(string.Join(",", GetStudentsByGroup2LINQ(studentList)));
            Console.WriteLine(new string('-', 30));

            // Test 2: Extract all students that have email in abv.bg ---> Problem 11 
            Console.WriteLine("Students, with email in abv.bg:\n");

            Console.WriteLine(string.Join(",", ExtractByEmail(studentList)));
            Console.WriteLine(new string('-', 30));

            // Test 3: Extract all students with phones in Sofia ---> Problem 12
            Console.WriteLine("All students with phones in Sofia:\n");

            Console.WriteLine(string.Join(",", ExtractBySofiaPhone(studentList)));
            Console.WriteLine(new string('-', 30));

            // Test 4: Select all students that have at least one mark Excellent (6) into a new anonymous class 
            // that has properties – FullName and Marks.  ---> Problem 13
            var extractedByExcellent =
               from studs in studentList
               where studs.Marks.Contains(6)
               select new { FullName = studs.FirstName + " " + studs.LastName, Marks = string.Join(",", studs.Marks) };

            Console.WriteLine("All students who have an excellent mark:\n");
            foreach (var item in extractedByExcellent)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));

            // Test 5: Extract students with two marks ---> Problem 14
            Console.WriteLine("All students who have an two failed marks:\n");

            var extractFailedStudents = studentList
                .Where(x => x.Marks.FindAll(y => y == 2).Count == 2)
                .Select(x => new {FullName = x});

            foreach (var item in extractFailedStudents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));

            // Test 6: Extract all Marks of the students that enrolled in 2006 ---> Problem 15
            Console.WriteLine("All Marks of the students that enrolled in 2006:\n");

            var enrolledIn2006Marks =
                 from studs in studentList
                 where (studs.FN % 100 == 6)
                 select new { Marks = string.Join(",", studs.Marks) };

            foreach (var item in enrolledIn2006Marks)
            {
                Console.WriteLine(item);
            }

            // Alternatively, with LAMBDA
            // var smth = studentArray
            //    .Where(x => x.FN % 100 == 6)
            //    .Select(x => new { Marks = string.Join(",", x.Marks) });

            Console.WriteLine(new string('-', 30));
        }

        private static IEnumerable<Student> GetStudentsByGroup2LAMBDA(List<Student> studentList)
        {
            var result = studentList
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList();

            return result;
        }

        private static IEnumerable<Student> GetStudentsByGroup2LINQ(List<Student> studentList)
        {
            var result =
                from studs in studentList
                where studs.GroupNumber == 2
                orderby studs.FirstName
                select studs;

            return result;
        }

        private static IEnumerable<Student> ExtractByEmail(List<Student> studentList)
        {
            var result = studentList
                .Where(x => x.Email.Contains("@abv.bg"))
                .ToList();

            return result;
        }

        private static IEnumerable<Student> ExtractBySofiaPhone(List<Student> studentList)
        {
            var result = studentList
                .Where(x => x.Tel.Contains("+3592"))
                .ToList();

            return result;
        }

    }
}

