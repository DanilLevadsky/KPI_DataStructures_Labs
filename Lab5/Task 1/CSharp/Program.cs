using System;

namespace CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var start = new double[3] {1.0, -0.5, 12.0};
            var end = new double[3] {9.0, 6.0, -1.0};
            var segm = new Segment(start, end);
            Console.WriteLine($"Length: {segm.Length}");
            Console.WriteLine($"Angle with oX: {segm.oX_angle} degrees");
        }
    }
}