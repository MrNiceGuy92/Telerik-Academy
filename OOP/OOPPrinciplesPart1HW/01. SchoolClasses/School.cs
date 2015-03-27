namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        // Field
        private string name;
        private List<Class> classes;

        // Constructor
        public School(string name)
        {
            this.Name = name;
            this.Classes = new List<Class>();
        }

        // Properties
        public string Name { get; set; }

        public List<Class> Classes 
        {
            get 
            { 
                return new List<Class>(this.classes); 
            }

            set
            {
                this.classes = value;
            }

        }

        // Method for adding class
        public void AddClass(Class newClass)
        {
            this.classes.Add(newClass);
        }
    }
}
