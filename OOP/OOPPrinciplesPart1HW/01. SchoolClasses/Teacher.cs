namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People, IComment
    {
        // Fields
        private List<Disciplines> disciplines;

        private string comment;

        // Constructors
        public Teacher(string name) 
            : base(name)
        {
            this.disciplines = new List<Disciplines>();
        }

        public Teacher(string name, string comment) 
            : base(name)
        {
            this.Comment = comment;
        }

        public List<Disciplines> Disciplines
        {
            get
            {
                return new List<Disciplines>(this.disciplines);
            }
        }

        // Method for adding disciplines
        public void AddDiscipline(Disciplines discipline)
        {
            this.disciplines.Add(discipline);
        }
    }
}
