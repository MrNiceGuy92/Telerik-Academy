namespace Shapes
{
    using System;

    public abstract class Shape
    {
        public double width;

        public double height;

        public Shape(double height, double width) 
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width 
        {
            get 
            { 
                return this.width; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative.");
                }

                this.width = value;
            }
        }

        public virtual double Height 
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative.");
                }
                this.height = value;
            }
        }

        public abstract decimal CalcSurface();
    }
}
