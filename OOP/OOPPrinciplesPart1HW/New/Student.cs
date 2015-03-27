namespace StudentsAndWorkers
{
    public class Student : AbstHuman
    {
        // Constructor for Student
        public Student(string firstName, string lastName, double grade)
            : base (firstName, lastName)
        {
            this.Grade = grade;
        }

        // Inherited properties from abstract classs
        public override string FirstName { get; set; }
        
        public override string LastName { get; set; }

        // New property created specifically for class Student
        public double Grade { get; set; }

        // Overriding .ToString() method
        public override string ToString()
        {
            return string.Format("{0} {1}\n", this.FirstName, this.LastName);
        }
    }
}
