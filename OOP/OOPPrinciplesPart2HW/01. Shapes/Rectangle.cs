namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            : base(height, width)
        {
        }

        public override decimal CalcSurface()
        {
            return (decimal)(Width * Height);
        }
    }
}
