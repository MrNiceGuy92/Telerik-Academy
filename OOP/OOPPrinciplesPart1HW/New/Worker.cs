namespace StudentsAndWorkers
{ 
    public class Worker : AbstHuman
    {
        // Constructor for Worker
        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.MoneyPerHour();
        }

        // Inherited properties from abstract class
        public override string FirstName { get; set; }
      
        public override string LastName { get; set; }
        
        // Properties created specifically for Worker class
        public decimal WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        // .MoneyPerHour() method
        public decimal MoneyPerHour()
        {
            var perDaySalary = (decimal)this.WeekSalary / 5; // Divide by five working days
            var result = perDaySalary / (decimal)this.WorkHoursPerDay;

            return result;
        }

        // Overriding .ToString() method
        public override string ToString()
        {
            return string.Format("{0} {1} --> Money Per Hour: {2:F5}\n", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
