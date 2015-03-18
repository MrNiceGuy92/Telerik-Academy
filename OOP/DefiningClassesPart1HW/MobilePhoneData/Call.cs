namespace MobilePhoneData
{
using System;

    public class Call
    {
        private DateTime date; 
        private string dialledPhoneNumber = null;
        private decimal duration = 0;

        // Empty constructor
        public Call()
        {
        }

        // Full constructor 
        public Call(DateTime date, string dialledPhoneNumber, decimal duration)
        {
            this.Date = date;
            this.Duration = duration;
            this.DialledPhoneNumber = dialledPhoneNumber;
        }

        // DateTime property
        public DateTime Date 
        {
            get
            {
                if (this.date == null)
                {
                    throw new NullReferenceException("Date cannot be null");
                }

                return this.date;
            }

            set 
            { 
                this.date = value; 
            }
        }

        // Duration property
        public decimal Duration 
        {
            get
            {
                if (this.duration == null)
                {
                    throw new NullReferenceException("Duration cannot be null.");
                }

                return this.duration;
            }

            set 
            { 
                this.duration = value; 
            }
        }

        // Dialled phone numbers property
        public string DialledPhoneNumber 
        {
            get
            {
                if (this.dialledPhoneNumber == null)
                {
                    throw new NullReferenceException("Phone number must be existent.");
                }

                return this.dialledPhoneNumber;
            }

            set 
            { 
                this.dialledPhoneNumber = value; 
            }
        }

        // Overriding ToString() method
        public override string ToString()
        {
            string result = string.Format("Call Date: {0}\nCall Duration: {1}\nDialled Number: {2}",
                   this.date, this.duration, this.dialledPhoneNumber);

            return result;
        }
    }
}
