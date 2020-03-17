using System;
using System.Linq;
using System.Diagnostics.CodeAnalysis;


namespace CSharp
{
    internal class Line
    {
        protected double[][] Coordinates { get; }
        protected internal double Length { get; }

        protected Line(double[] start, double[] end)
        {
            this.Coordinates = new double[2][] {start, end};
            this.Length = GetLength();
        }

        private double GetLength()
        {
            var sum = 0.0;
            for (var i = 0; i < 3; i++)
            {
                sum += Math.Pow(Math.Abs(this.Coordinates[1][i]-this.Coordinates[0][i]), 2);
            }

            return Math.Sqrt(sum);
        }
    }
}
