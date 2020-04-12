using System;

namespace CSharp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var start = new double[3] {0.0, 0.5, 0.0};
            var end = new double[3] {0.0, 6.0, 0.0};
            var segm = new Segment(start, end);
            Console.WriteLine($"Length: {segm.Length}");
            Console.WriteLine($"Angle with oX: {segm.OxAngle} degrees");
        }
    }
}