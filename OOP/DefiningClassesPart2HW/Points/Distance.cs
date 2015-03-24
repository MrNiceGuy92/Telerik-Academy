namespace Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Distance
    {
        private static double distance;

        public static double GetDistance(Point3D firstPoint, Point3D secondPoint)
        {
            distance = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X)
                + (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y)
                + (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));

            return distance;
        }
    }
}
