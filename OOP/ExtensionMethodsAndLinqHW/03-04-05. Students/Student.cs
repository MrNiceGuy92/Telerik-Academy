namespace _03_04_05.Students
{
    public class Student
    {
        private Student students;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        // Override .ToString() method
        public override string ToString()
        {
            return string.Format("{0} {1} Age: {2}", this.FirstName, this.LastName, this.Age);
        } 
    }
}
