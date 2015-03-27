namespace StudentsAndWorkers
{
    public abstract class AbstHuman
    {
        // Constructor
        public AbstHuman(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // Abetract proerties
        public abstract string FirstName { get; set; }

        public abstract string LastName { get; set; }
    }
}
