namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double height, double width)
            : base(height, width)
        {
        }

        public Square(double side)
            : base(side, side)
        {
        }

        public override double Height
        {
            get
            {
                return base.height;
            }

            set
            {
                if (value.Equals(this.width))
                {
                    throw new ArgumentException("Width and height must be equal.");
                }

                this.height = value;
            }
        }

        public override decimal CalcSurface()
        {
            return (decimal)this.Height * (decimal)this.Height;
        }
    }
}
