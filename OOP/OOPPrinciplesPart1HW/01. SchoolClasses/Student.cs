namespace SchoolClasses
{
    using System;

    public class Student : People, IComment
    {
        // Fields
        private string uniqueClassNum;
        private string comment;

        // Constructors
        public Student(string name, string uniqueClassNum) 
            : base(name)
        {
            this.UniqueClassNum = uniqueClassNum;
        }

        public Student(string name, string uniqueClassNum, string comment) 
            : this(name, uniqueClassNum)
        {
            this.Comment = comment;
        }

        // Proerties
        public string UniqueClassNum 
        { 
            get
            {
                return this.uniqueClassNum;
            }

            private set
            {
                if (value.Length < 7)
                {
                    throw new ArgumentException("Unique class number is not big enough.");
                }

                this.uniqueClassNum = value;
            }
        }
    }
}
