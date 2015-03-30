namespace Student
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        // Fields
        private string firstName;

        private string middleName;

        private string lastName;

        private long ssn;

        private string permanentAddress;

        private string mobilePhoneNumber;

        private string emailAddress;

        private string course;

        private Universities universities;
        private Faculties faculties;
        private Specialties specialties;

        // Full Constructor (Style Cop layout)
        public Student(
            string firstName, string middleName, string lastName, long ssn, string mobilePhoneNumber, string permanentAddress, string emailAddress, string course, Specialties specialties, Faculties faculties, Universities universities)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.PermanentAddress = permanentAddress;
            this.EmailAddress = emailAddress;
            this.Course = course;
            this.Specialties = specialties;
            this.Faculties = faculties;
            this.Universities = universities;
        }

        // Properities
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }

                this.lastName = value;
            }
        }

        public string WholeName
        {
            get
            {
                return string.Format("{0} {1} {2}", FirstName, MiddleName, LastName);
            }
        }

        public long Ssn
        {
            get { return this.ssn; }
            protected set { this.ssn = value; }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Permanent Address is invalid.");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhoneNumber
        {
            get
            {
                return this.mobilePhoneNumber;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid Phone number!");
                }

                this.mobilePhoneNumber = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid email address!");
                }

                this.emailAddress = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid course!");
                }

                this.course = value;
            }
        }

        public Specialties Specialties { get; set; }

        public Faculties Faculties { get; set; }

        public Universities Universities { get; set; }

        // Override == operator
        public static bool operator ==(Student a, Student b)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if course matches
            return a.Course == b.Course;
        }

        // Override != operator
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

        // Override .ToString() method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("FirstName: {0}", this.FirstName));
            sb.AppendLine(string.Format("MiddleName: {0}", this.MiddleName));
            sb.AppendLine(string.Format("LastName: {0}", this.LastName));
            sb.AppendLine(string.Format("SSN: {0}", this.Ssn));
            sb.AppendLine(string.Format("Address: {0}", this.PermanentAddress));
            sb.AppendLine(string.Format("Phone: {0}", this.MobilePhoneNumber));
            sb.AppendLine(string.Format("Email: {0}", this.EmailAddress));
            sb.AppendLine(string.Format("Course: {0}", this.Course));
            sb.AppendLine(string.Format("Specialty: {0}", this.Specialties));
            sb.AppendLine(string.Format("Faculty: {0}", this.Faculties));
            sb.AppendLine(string.Format("University: {0}", this.Universities));

            return sb.ToString();
        }

        // Override .Equals() method
        public override bool Equals(object obj)
        {
            Student stud = obj as Student;

            // If parameter is null return false.
            if (stud == null)
            {
                return false;
            }

            if (this.Ssn == stud.Ssn)
            {
                return true;
            }
            
            if (this.Faculties == stud.Faculties)
            {
                return true;
            }

            if (this.Course == stud.Course)
            {
                return true;
            }

            return false;
        }

        // Override .GetHashCode() method
        public override int GetHashCode()
        {
            return (int)this.Ssn.GetHashCode() ^ (int)this.Ssn / 2;
        }

        // .Clone() method
        object ICloneable.Clone()
        {
            var copy = new Student(
                this.firstName, this.middleName, this.lastName, this.ssn, this.mobilePhoneNumber, this.permanentAddress, this.emailAddress, this.course, this.specialties, this.faculties, this.universities);

            return copy;
        }

        // CompareTo method
        public int CompareTo(Student students)
        {
            if (this.WholeName.CompareTo(students.WholeName) != 0)
            {
                return this.WholeName.CompareTo(students.WholeName);
            }

            if (this.Ssn.CompareTo(students.Ssn) !=0)
            {
                return this.Ssn.CompareTo(students.Ssn);
            }
                
            return 0;
        }

    }
}
