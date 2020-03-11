using System;

namespace Lab3
{
    public class MyClass
    {
        private int[,] matValue;
        private int length;
        private int width;
        private int amountOfElements;

        public int[,] Matrix { get => matValue; set => matValue = value; }

        public int Length => length;
        public int Width => width;

        public int AmountOfElements => amountOfElements;

        public MyClass(int length, int width)
        {
            this.Matrix = new int[length, width];
            this.length = Matrix.GetLength(0);
            this.width = Matrix.GetLength(1);
            this.amountOfElements = length * width;

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
                    throw;
                }
                
            }
        }

        private void Checker(int index1, int index2) 
        {
            if (index1 < 0 || index1 >= Matrix.GetLength(0))
            {
                throw new IndexOutOfRangeException("Out of range.");
            }

            if (index2 < 0 || index2 >= Matrix.GetLength(1))
            {
                throw new  IndexOutOfRangeException("Out of range.");
            }
        }
        
        
        
    }
}