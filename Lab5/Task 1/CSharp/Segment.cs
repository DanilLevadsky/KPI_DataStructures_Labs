using System;

namespace CSharp
{
    public class Segment : Line
    {
        public double OxAngle { get; }

        public Segment(double[] start, double[] end) : base(start, end)
        {
            OxAngle = GetXAngle();
        }

        private double GetXAngle()
        {
            var radians =  Math.Acos(Math.Abs(this.Coordinates[1][0] - this.Coordinates[0][0]) / this.Length);
            return radians * 180 / Math.PI;
        }
    }
}