namespace Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D() { X = 0, Y = 0, Z = 0 };

        //public Point3D(int x, int y, int z) : this()
        //{
        //    this.X = x;
        //    this.Y = y;
        //    this.Z = z;
        //}

        public static Point3D PointO { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("X coordinate: {0}", this.X));
            result.AppendLine(string.Format("Y coordinate: {0}", this.Y));
            result.AppendLine(string.Format("Z coordinate: {0}", this.Z));

            return result.ToString();
        }
    }
}