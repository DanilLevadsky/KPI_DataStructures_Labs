using System;
using static CSharp.Log;

namespace CSharp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var array = new Expression[6]
            {
                new Expression(-3, 2, 3), new Expression(12, 2, 0), 
                new Expression(2.1, 5, 1), new Expression(5.0, 2, -1), 
                new Expression(-1, 2, 5), new Expression(0,1,3)
            };
            foreach (var exp in array)
            {
                try
                {
                    var result = exp.Calculate();
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception e)
                {
                    LogException(e);
                }
            }
        }
    }
}