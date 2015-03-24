namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Points;

    public class TestPoints
    {
        public static void Main()
        {
            var somePoint = new Point3D() { X = 1, Y = 3, Z = 5 };

            Console.WriteLine(somePoint);
            Console.WriteLine(Point3D.PointO);

            var firstPoint = new Point3D() { X = 1, Y = 1, Z = 1 };
            var distance = Distance.GetDistance(firstPoint, Point3D.PointO);
            Console.WriteLine(string.Format("Distance: {0}\n", distance));

            // Get the points from GetPaths.txt from Debug folder
            Console.WriteLine("Getting points from text file: ");
            Console.WriteLine(PathStorage.GetPathsFromFile());

            // Saving array of points to txt file
            // The coordinates are saved in SavePaths.txt in the Debug folder
            Point3D[] somePaths = new Point3D[3];
            somePaths[0] = new Point3D() { X = 1, Y = 1, Z = 1 };
            somePaths[1] = new Point3D() { X = 2, Y = 2, Z = 2 };
            somePaths[2] = new Point3D() { X = 3, Y = 3, Z = 3 };

            PathStorage.SavePathsToFile(somePaths);
        }
    }
}
