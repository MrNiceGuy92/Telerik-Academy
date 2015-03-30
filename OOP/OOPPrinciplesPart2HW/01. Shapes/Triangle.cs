namespace Shapes
{
    public class Triangle : Shape 
    {
        public Triangle(double height, double width)
            : base (height, width)
        {
        }

        public override decimal CalcSurface()
        {
            return (decimal)(Width * Height) / 2;
        }
    }
}
