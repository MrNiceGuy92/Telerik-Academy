namespace MobilePhoneData
{
    using System;

    public class Battery
    {
        private string batteryModel = null; // Null initialization
        private double hoursIdle = 0; // Zero initialization
        private double hoursTalk = 0; // Zero initialization
        private BatteryType type;

        // Empty constructor
        public Battery()
        {
        }

        // Some other constructor
        public Battery(string batteryModel, BatteryType batteryType) : this()
        {
            this.BatteryModel = batteryModel;
            this.Type = type;
        }

        // Full constructor
        public Battery(string batteryModel, double hoursIdle, double hoursTalk, BatteryType Type)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type; 
        }

        // Property for Battery type
        public BatteryType Type { get; set; }

        // Property for Battery model
        public string BatteryModel
        {
            get 
            { 
                return this.batteryModel; 
            }
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null.");
                }

                this.batteryModel = value;
            }
        }

        //Property for Battery Hours Idle
        public double HoursIdle
        {
            get 
            { 
                return this.hoursIdle; 
            }

            set
            {
                if (value <= 0 || value >= 9)
                {
                    throw new ArgumentOutOfRangeException("Hours idle is too little or too much.");
                }

                this.hoursIdle = value;
            }
        }

        //Property for Battery Hours Talk
        public double HoursTalk
        {
            get 
            { 
                return this.hoursTalk; 
            }

            set
            {
                if (value <= 0 || value >= 6)
                {
                    throw new ArgumentOutOfRangeException("Hours talk exceed minimum or maximum.");
                }
            
                this.hoursTalk = value;
            }
        }

        // Override of ToString() method
        public override string ToString()
        {
            return string.Format("Model: {0}, Hours idle: {1}, Hours talk: {2}, Type: {3}",
                                     this.batteryModel, this.hoursIdle, this.hoursTalk, this.type);
        }
    }
}