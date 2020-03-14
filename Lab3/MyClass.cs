using System;

namespace Lab3
{
    public class MyClass
    {
        public int[,] Matrix { get; set; }
        public int Length { get; }
        public int Width { get; }
        public int AmountOfElements { get; }

        public MyClass(int length, int width)
        {
            this.Matrix = new int[length, width];
            this.Length = Matrix.GetLength(0);
            this.Width = Matrix.GetLength(1);
            this.AmountOfElements = length * width;
        }

        public int? this[int index1, int index2]
        {
            get
            {
                try
                {
                    return Matrix[index1, index2];
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range");
                    return null;
                }
            }
            set
            {
                try
                {
                    if (value != null) Matrix[index1, index2] = (int) value;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range");
                    throw;
                }
            }
        }

    }
}