namespace _18._19.StudentGrouping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _09._15.StudentExtractions;

    public class Tests 
    {
        public static void Main()
        {
            var studentList = new List<Student>
            {
                new Student("Michael", "Jordan", 230006, "bulls@abv.bg", "+359212345", new List<int>(){6,5,6}, 3),
                new Student("Scottie", "Pippen", 330005, "rockets@yahoo.com", "+2591234567", new List<int>(){5,5,4}, 2),
                new Student("Dennis", "Rodman", 910006, "pistons@abv.bg", "+35921234567",  new List<int>(){5,4,4}, 3),
                new Student("Rory", "Sparrow", 200005, "knicks@gmail.com", "+1267",  new List<int>(){3,5,4}, 4),
                new Student("Magic", "Johnson", 320006, "lakers@hotmail.com", "+3592124567",  new List<int>(){2,2,2}, 1),
                new Student("Derric", "Rose", 100005, "bulls@hotmail.com", "+3594098567",  new List<int>(){2,6,5}, 2),
                new Student("Vince", "Carter", 100006, "grizlies@hotmail.com", "+359486768567",  new List<int>(){2,6,4}, 3),
            };

            // Test 1: Extract all students grouped by GroupNumber (with LINQ) ---> Problem 18
            Console.WriteLine("Extract all students grouped by GroupNumber (with LINQ):\n");

            var firstResult =
                from students in studentList
                group students by students.GroupNumber into someGroup
                select new { GroupNumber = someGroup.Key, Students = string.Join(",", someGroup) };

            foreach (var item in firstResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));

            // Test 2: Extract all students grouped by GroupNumber (with LAMBDA) ---> Problem 19
            Console.WriteLine("Extract all students grouped by GroupNumber (with LAMBDA):\n");

            var secondResult = studentList
                .GroupBy(x => x.GroupNumber)
                .Select(x => new { GroupNumber = x.Key, Students = string.Join(",", x) });

            foreach (var item in secondResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
