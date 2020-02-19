using System;
using System.Linq;

namespace Lab1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Increment(63); // result is 64
            Increment(-18); // result is -17
            Increment(92); // result is 93
            IfMore(11, -1); // result is true
            IfMore(-1, -11); // result is true
            IfMore(-1, 1); // result is false
        }

        private static int Increment(int number) //Increment function, using 'return'
        {
            return -~number;
        }

        private static void Increment(int number, out int result) // returning via parameter
        {
            result = -~number;
        }

        private static int Addition(int number1, int number2)
        {
            while (number2 != 0)
            {
                var carry = number1 & number2;
                number1 ^= number2;
                number2 = carry << 1;
            }

            return number1;
        }

        private static bool IfMore(int number1, int number2)
        {
            var sign = Addition(number1, Addition(~number2, 1));
            sign >>= 31;
            return sign == 0;
        }

        private static void IfMore(int number1, int number2, ref bool result)
        {
            var sign = Addition(number1, Addition(~number2, 1));
            sign >>= 31;
            result = Convert.ToBoolean(sign == 0);
        }
    }
}