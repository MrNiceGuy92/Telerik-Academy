namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    
    public class Class : IComment
    {
        // Fields
        private string identifier;

        private string comment;

        // Constructor
        public Class(string identifier, List<Student> students, List<Teacher> teachers)
            : base()
        {
            this.Identifier = identifier;
            this.Students = students;
            this.Teachers = teachers;
        }

        // Properties
        public string Identifier 
        {
            get 
            {
                return this.identifier;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Identifier cannot be null.");
                }

                this.identifier = value;
            }
        }

        public List<Student> Students { get; private set; }

        public List<Teacher> Teachers { get; private set; }

        // Property from IComment interface
        public string Comment
        {
            get
            {
                return this.comment;
            }

            private set
            {
                this.comment = value;
            }
        }
    }
}