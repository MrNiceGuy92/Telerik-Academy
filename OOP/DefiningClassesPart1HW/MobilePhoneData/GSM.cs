namespace MobilePhoneData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSM
    {
        // Static field for iPhone
        private static GSM iPhone4S = new GSM("Apple Iphone", "Apple Corporation", "Lucky dude", 799.99M,
                            new Battery("Apple bat.", BatteryType.NiMH),
                            new Display(2.6, 23));

        // Non-static fields
        private string model = null; // Null initialization
        private string manufacturer = null; // Null initialization
        private string owner = null; // Zero initialization
        private decimal price = 0M; // Zero initialization

        private List<Call> callHistory;

        // Parameterless constructor
        public GSM()
        {
        }

        // Almost full constructor
        public GSM(string model, string manufacturer, string owner, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Price = price;
        }

        // Full constructor
        public GSM(string model, string manufacturer, string owner, decimal price,
                        Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Price = price;
            this.Battery = battery;
            this.Display = display;
        }

        // GSM Model property
        public string Model
        {
            get 
            { 
                return this.model; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null.");
                }

                this.model = value;
            }
        }

        // Static Property for iPhone4S
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        // GSM Manufacturer property
        public string Manufacturer
        {
            get 
            { 
                return this.manufacturer; 
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null.");
                }

                this.manufacturer = value;
            }
        }

        // GSM Owner property
        public string Owner
        {
            get 
            { 
                return this.owner; 
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner cannot be null.");
                }

                this.owner = value;
            }
        }

        // GSM Price property
        public decimal Price
        {
            get 
            { 
                return this.price; 
            }

            set
            {
                if (value <= 0 || value >= 999.99M)
                {
                    throw new ArgumentException("Too expensive or too cheap.");
                }

                this.price = value;
            }
        }

        // Battery property
        public Battery Battery { get; set; }

        // Display property
        public Display Display { get; set; }

        // Call History Property
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        // Override ToString() Method
        public override string ToString()
        {
            string result = string.Format(
                "GSM Model: {0}\n" +
                "GSM Manufacturer: {1}\n" +
                "GSM Owner: {2}\n" +
                "GSM Price: {3}\n" +
                "Battery Info: {4}\n" +
                "Display Info: {5}\n",
                this.Model,
                this.Manufacturer,
                this.Owner, 
                this.Price,
                this.Battery,
                this.Display);

            return result;
        }

        // Add/Delte Call methods
        public List<Call> AddCalls(Call call)
        {
            this.CallHistory.Add(call);
            return new List<Call>(this.callHistory);
        }

        public List<Call> DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return new List<Call>(this.callHistory);
        }

        // Clear Call History Method
        public List<Call> ClearHistory()
        {
            this.CallHistory.Clear();
            return new List<Call>(this.callHistory);
        }

        // Call Price Methods
        public decimal TotalCost(decimal price)
        {
            decimal total = 0m;
            foreach (var call in this.CallHistory)
            {
                total += price * call.Duration / 60;
            }
            return total;
        }

        // Print Call History method
        public string PrintCallHistory()
        {
            return string.Format("Calls history:\n{0}", string.Join(Environment.NewLine, new List<Call>(this.callHistory)));
        }
    }
}