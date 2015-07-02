namespace CSharp.Task4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PointsStandingInfo
    {
        private string namе;
        private int points;

        public PointsStandingInfo() 
        { 
        }

        public PointsStandingInfo(string namе, int points)
        {
            this.Namе = namе;
            this.Points = points;
        }

        public string Name
        {
            get
            {
                return this.namе;
            }

            set
            {
                this.namе = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                this.points = value;
            }
        }
    }
}