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
            MoreThan(88, 88); // result is false (88 is equal 88, but not more)
            MoreThan(34, 2); // result is true (34 is more than 2)
            MoreThan(23, 57); // result is false (23 is less than 57)
            
        }
       
        private static string DecimalToBinary(int number)
        {
            var result = Convert.ToString(number, 2);
            return number < 0 ? result.Substring(Math.Max(result.Length - 8, 0)).PadLeft(8, '0') : result;
        }
        
        private static int Increment(int number) //Increment function, using 'return'
        {
            var result = number;
            var index = DecimalToBinary(number).LastIndexOf('0');
            for (var i = 0; i < DecimalToBinary(number).Length-index; i = -~i)
            {
                result ^= (1 << i);
            }

            return result;
        }

        private static void Increment(int number, out int result) // returning via parameter
        {
            var increasedByOne = number;
            var index = DecimalToBinary(number).LastIndexOf('0');
            for (var i = 0; i < DecimalToBinary(number).Length-index; i = -~i)
            {
                increasedByOne ^= (1 << i);
            }

            result = increasedByOne;
        }
        
        private static bool MoreThan(int number1, int number2)
        {
            var binary1 = ExtendBits(DecimalToBinary(number1), 16);
            var binary2 = ExtendBits(DecimalToBinary(number2), 16);
            for (var i = 0; i < 16; Increment(i, out i))
            {
                
                if ((Convert.ToInt32(binary1[i].ToString()) & 1) == 1)
                {
                    if ((Convert.ToInt32(binary1[i].ToString()) ^ Convert.ToInt32(binary2[i].ToString())) == 1)
                    {
                        if (Convert.ToInt32(binary2[i].ToString()) != 1)
                        {
                            return true;
                        }
                    }
                }

                if (((Convert.ToInt32(binary1[i].ToString())) & 1) != 1)
                {
                    if ((Convert.ToInt32(binary2[i].ToString()) & 1) == 1)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        
        private static void MoreThan(int number1, int number2, out bool result)
        {
            var binary1 = ExtendBits(DecimalToBinary(number1), 16);
            var binary2 = ExtendBits(DecimalToBinary(number2), 16);
            for (var i = 0; i < 16; Increment(i, out i))
            {
                
                if ((Convert.ToInt32(binary1[i].ToString()) & 1) == 1)
                {
                    if ((Convert.ToInt32(binary1[i].ToString()) ^ Convert.ToInt32(binary2[i].ToString())) == 1)
                    {
                        if (Convert.ToInt32(binary2[i].ToString()) != 1)
                        {
                            result = true;
                            return;
                        }
                    }
                }

                if (((Convert.ToInt32(binary1[i].ToString())) & 1) != 1)
                {
                    if ((Convert.ToInt32(binary2[i].ToString()) & 1) == 1)
                    {
                        result = false;
                        return;
                    }
                }
            }

            result = false;
        }
        private static string ExtendBits(string binary, int length) 
        {
            return binary.PadLeft(length, '0');
        }

    }
}