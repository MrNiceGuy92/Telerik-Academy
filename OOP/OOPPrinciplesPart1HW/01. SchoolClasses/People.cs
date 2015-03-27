namespace SchoolClasses
{
    using System;

    public abstract class People : IComment
    {
        private string name;

        private string comment;

        public People(string name)
        {
            this.Name = name;
        }

        // Name property
        public string Name 
        { 
            get
            {
                return this.Name;
            }
                
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("name must not be empty.");
                }

                this.name = value;
            }
        }

        // Comment property from IComment interface
        public string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }
    }
}
