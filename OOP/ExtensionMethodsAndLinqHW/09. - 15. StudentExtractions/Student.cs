namespace _09._15.StudentExtractions
{
    using System.Collections.Generic;

    public class Student
    {
        private Student students;

        public Student(string firstName, string lastName, int fN, string email, string tel, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        #region All Properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; } // Faculty number

        public string Tel { get; private set; }

        public string Email { get; private set; }

        public List<int> Marks { get; private set; }

        public int GroupNumber { get; private set; }

        public Student Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        #endregion

        // Override .ToString() method
        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
