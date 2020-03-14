using System;

namespace Lab3
{
    class Program
    {
        private static void Main(string[] args)
        {
            const int width = 5;
            const int len = 6;
            var mat1 = new MyClass(len, width)
            {
                Matrix = new int[len, width]
                {
                    {1, 2, 3, 4, 5}, {2, 3, 4, 5, 6}, {3, 4, 1, 6, 7},
                    {4, 5, 6, 7, 8}, {0, 2, 2, 2, 5}, {1, 7, 3, 8, 5}
                }
            };
            ReadMatrix(mat1);
            mat1[2, 2] = 0;
            mat1[3, 2] = 0;
            mat1[2, 3] = 0;
            mat1[1, 1] = 0;
            mat1[3, 3] = 0;
            ReadMatrix(mat1);
            Console.WriteLine($"Length: {mat1.Length}");
            Console.WriteLine($"Width: {mat1.Width}");
            Console.WriteLine($"Number of elements: {mat1.AmountOfElements}");
            try {
                mat1[7, 1] = 12;   
            }
            catch(IndexOutOfRangeException){
                Console.WriteLine("Out of range");
            }

        }


        private static void ReadMatrix(MyClass matr)
        {
            for (var i = 0; i < matr.Matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matr.Matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matr[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
