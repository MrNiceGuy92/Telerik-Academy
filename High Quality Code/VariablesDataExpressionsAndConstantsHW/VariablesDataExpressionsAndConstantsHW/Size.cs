namespace VariablesDataExpressionsAndConstantsHW
{
    using System;
    using System.Text;
    using System.Threading.Tasks;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public static Size GetRotatedSize(Size s, double rotatedFigure)
        {
            Size result = new Size(Math.Abs(Math.Cos(rotatedFigure)) * s.width +
                                      Math.Abs(Math.Sin(rotatedFigure)) * s.height,
                                      Math.Abs(Math.Sin(rotatedFigure)) * s.width +
                                      Math.Abs(Math.Cos(rotatedFigure)) * s.height);
            return result;
        }
    }
}