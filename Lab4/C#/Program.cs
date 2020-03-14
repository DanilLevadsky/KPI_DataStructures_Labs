using System;
using System.Numerics;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(); v1.VectorInfo();
            var v2 = new Vector(5, 0, 12); v2.VectorInfo();
            var v3 = new Vector(new Vector(3, 3, 3)); v3.VectorInfo();
            v3 *=  2; v3.VectorInfo();
            v1 = v3 - v2; v1.VectorInfo();
            
            
        }

        
    }
}