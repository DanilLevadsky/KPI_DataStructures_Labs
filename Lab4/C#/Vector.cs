using System;
using System.Reflection.Metadata.Ecma335;

namespace CSharp
{
    public class Vector
    {
        private double XCoord { get; set; } // coordinate X
        private double YCoord { get; set; } // coordinate Y
        private double ZCoord { get; set; } // coordinate Z
        private double Length { get; set; } // length of a Vector

        public Vector() // default constructor, null vector
        {
            this.XCoord = 0;
            this.YCoord = 0;
            this.ZCoord = 0;
            this.Length = Math.Sqrt(Math.Pow(this.XCoord, 2) + Math.Pow(this.YCoord, 2) + Math.Pow(this.ZCoord, 2));
        }

        public Vector(double x, double y, double z) // constructor with parameters(coordinates of vector)
        {
            this.XCoord = x;
            this.YCoord = y;
            this.ZCoord = z;
            this.Length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public Vector(Vector vec) // copy of another vector
        {
            this.XCoord = vec.XCoord;
            this.YCoord = vec.YCoord;
            this.ZCoord = vec.ZCoord;
            this.Length = vec.Length;
        }

        private double[] GetCoord() // method for getting coordinates of a Vector
        {
            var coord = new double[3] {this.XCoord, this.YCoord, this.ZCoord};
            return coord;
        }

        private double GetLength() // method for getting coordinates
        {
            return Math.Sqrt(Math.Pow(this.XCoord, 2) + Math.Pow(this.YCoord, 2) + Math.Pow(this.ZCoord, 2));
        }
        
        private double this[int index]
        {
            get
            {
                var coord = this.GetCoord();
                return coord[index];
            }
        }
        
        public void VectorInfo() // printing info about a vector
        {
            Console.WriteLine("Vector`s length: {0}", this.Length);
            Console.WriteLine("Vector`s coordinates: ({0}, {1}, {2})\n", this.XCoord, this.YCoord, this.ZCoord);
            
        }
        
        public static Vector operator +(Vector vec1, Vector vec2) // vector addition
        {
            var result = new Vector
            {
                XCoord = vec1.XCoord + vec2.XCoord,
                YCoord = vec1.YCoord + vec2.YCoord,
                ZCoord = vec1.ZCoord + vec2.ZCoord,
            };
            result.Length = result.GetLength();
            return result;
        }
        public static Vector operator -(Vector vec1, Vector vec2) // vector subtraction
        {
            var result = new Vector
            {
                XCoord = vec1.XCoord - vec2.XCoord,
                YCoord = vec1.YCoord - vec2.YCoord,
                ZCoord = vec1.ZCoord - vec2.ZCoord
            };
            result.Length = result.GetLength();
            return result;
        }
        
        public static double operator *(Vector vec1, Vector vec2) //scalar product of vectors
        {
            var sum = .0;
            for (var i = 0; i < 3; i++)
            {
                sum += (vec1[i] * vec2[i]);
            }

            return sum;
        }

        public static Vector operator *(Vector vector, double times) // increase a vector
        {
            vector.XCoord *= times;
            vector.YCoord *= times;
            vector.ZCoord *= times;
            vector.Length *= times;
            return vector;
        } 
        
        
    }
}