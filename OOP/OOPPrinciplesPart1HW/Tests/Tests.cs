namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentsAndWorkers;

    public class Tests
    {
        public static void Main()
        {
            var Students = new List<Student>()
            {
                new Student("George", "Washington", 5.4),
                new Student("Abraham", "Lincoln", 4.5),
                new Student("Barack", "Obama", 4.9),
                new Student("Thomas", "Jefferson", 3.6),
                new Student("Andrew", "Jakson", 6.0),
                new Student("Ulysses S.", "Grant", 4.5),
                new Student("Chester", "Arhtur", 5.0),
                new Student("John F.", "Kennedy", 5.8),
                new Student("George", "Bush", 2.0),
                new Student("Franklin D.", "Roosevelt", 3.2),
            };
        }
    }
}
