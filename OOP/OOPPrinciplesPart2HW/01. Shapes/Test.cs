namespace Shapes
{
    using System;
    using System.Collections.Generic;
    
    public class Test
    {
        static void Main()
        {
            var shapeArr = new Shape[]
            {
                new Square(4.5),
                new Rectangle(2, 3.5),
                new Triangle(4.5, 7.8),
            };

            foreach (var shape in shapeArr)
            {
                Console.Write("Surface of {0}: ", shape.GetType().Name);
                Console.WriteLine(shape.CalcSurface());
                Console.WriteLine();
            }
        }
    }
}
