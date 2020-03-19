using System;

namespace CSharp
{
    public class Vector
    {
        private double _xCoord; // coordinate X
        private double _yCoord; // coordinate Y
        private double _zCoord; // coordinate Z
        private double _length; // length of a Vector

        public Vector() // default constructor, null vector
        {
            this._xCoord = 0;
            this._yCoord = 0;
            this._zCoord = 0;
            this._length = GetLength();
        }

        public Vector(double x, double y, double z) // constructor with parameters(coordinates of vector)
        {
            this._xCoord = x;
            this._yCoord = y;
            this._zCoord = z;
            this._length = GetLength();
        }

        public Vector(Vector vec) // copy of another vector
        {
            this._xCoord = vec._xCoord;
            this._yCoord = vec._yCoord;
            this._zCoord = vec._zCoord;
            this._length = vec.GetLength();
        }

        private double[] GetCoord() // method for getting coordinates of a Vector
        {
            var coord = new double[3] {this._xCoord, this._yCoord, this._zCoord};
            return coord;
        }

        private double GetLength() // method for getting coordinates
        {
            return Math.Sqrt(Math.Pow(this._xCoord, 2) + Math.Pow(this._yCoord, 2) + Math.Pow(this._zCoord, 2));
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
            Console.WriteLine("Vector`s length: {0}", this._length);
            Console.WriteLine("Vector`s coordinates: ({0}, {1}, {2})\n", this._xCoord, this._yCoord, this._zCoord);
            
        }
        
        public static Vector operator +(Vector vec1, Vector vec2) // vector addition
        {
            var result = new Vector
            {
                _xCoord = vec1._xCoord + vec2._xCoord,
                _yCoord = vec1._yCoord + vec2._yCoord,
                _zCoord = vec1._zCoord + vec2._zCoord,
            };
            result._length = result.GetLength();
            return result;
        }
        public static Vector operator -(Vector vec1, Vector vec2) // vector subtraction
        {
            var result = new Vector
            {
                _xCoord = vec1._xCoord - vec2._xCoord,
                _yCoord = vec1._yCoord - vec2._yCoord,
                _zCoord = vec1._zCoord - vec2._zCoord
            };
            result._length = result.GetLength();
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
            vector._xCoord *= times;
            vector._yCoord *= times;
            vector._zCoord *= times;
            vector._length = vector.GetLength();
            return vector;
        } 
        public static Vector operator *(double times, Vector vector) // increase a vector
        {
            return vector * times;
        } 
        
    }
}