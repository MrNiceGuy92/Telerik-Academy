namespace MobilePhoneData
{
    using System;

    public class Display
    {
        private const double MaxSize = 7.5;
        private const double MinSize = 2.5;
        private const int MinNumOfColors = 2;

        private double displaySize = 0; // Zero initialization
        private int numOfColors = 0; // Zero initialization

        // Empty constructor
        public Display()
        {
        }

        // Full constructor
        public Display(double displaySize, int numOfColors) : this()
        {
            this.DisplaySize = displaySize;
            this.NumOfColors = numOfColors;
        }

        // Display Size property
        public double DisplaySize
        {
            get 
            { 
                return this.displaySize; 
            }

            set
            {
                if (value <= MinSize || value >= MaxSize)
                {
                    throw new ArgumentOutOfRangeException("Size is too big or too small.");
                }

                this.displaySize = value;
            }
        }

        // Number of display colors property
        public int NumOfColors
        {
            get 
            { 
                return this.numOfColors; 
            }

            set
            {
                if (value <= MinNumOfColors)
                {
                    throw new ArgumentOutOfRangeException("Number of colors cannot be negative.");
                }

                this.numOfColors = value;
            }
        }

        // Override ToString() method
        public override string ToString()
        {
            string result = string.Format("Diagonal length: {0}, Number of colors: {1}",
                                             this.displaySize, this.numOfColors);

            return result;
        }
    }
}
