namespace Person
{
    using System;
    using System.Text;

    public class Person
    {
        // Fields
        private string name;

        private int age;

        // Constructor
        public Person(string name, int age = default(int))
        {
            this.Name = name;
            this.Age = age;
        }

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("Invalid Age!");
                }

                this.age = value;
            }
        }

        // Overriding .ToString()
        public override string ToString()
        {
            if (this.Age.Equals(default(int)))
            {
                return string.Format("Person:\nName: {0}\n{1}", this.Name, "Age not specified.");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Person:");
                sb.AppendLine(string.Format("Name: {0}", this.Name));
                sb.AppendLine(string.Format("Age: {0}", this.Age));

                return sb.ToString();
            }
        }
    }
}

// Alternative solution

 // public string Name { get; private set; }
 //   public byte? Age { get; private set; }

 //   public Person(string name, byte? age = null)
 //   {
 //       this.Name = name;
 //       this.Age = age;
 //   }

 //   public override string ToString()
 //   {
 //       return string.Format("Name: {0} Age: {1}", Name, Age == null ? "no info": Age.ToString());
 //   }