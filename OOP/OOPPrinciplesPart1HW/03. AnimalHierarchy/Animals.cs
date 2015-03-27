namespace AnimalHierarchy
{
    public abstract class Animals : ISound
    {
        // Protected fields
        protected string name;
        protected int age;
        protected string sex;

        // Empty constructor (used later for Dog instantination)
        public Animals()
        {
        }

        // Full constructor
        public Animals(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        
        // Properties
        public string Name { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        // Method inherited from ISound interface
        public abstract void ProduceSound(Animals animal);
    }
}
