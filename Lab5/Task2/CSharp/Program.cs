using System;

namespace CSharp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var a = "qwERty".ToCharArray();
            var st1 = new CapitalLetter(a);
            var st2 = new LowerCase(a);
            var st = new MyString(a);
            Console.WriteLine(st.GetValue());
            Console.WriteLine(st.GetLength());
            Console.WriteLine(st1.GetValue());
            Console.WriteLine(st1.GetLength());
            Console.WriteLine(st2.GetValue());
            Console.WriteLine(st2.GetLength());
            st.Insert('o', 2);
            st1.Insert('o', 2);
            st2.Insert('o', 2);
            Console.WriteLine(st.GetValue());
            Console.WriteLine(st.GetLength());
            Console.WriteLine(st1.GetValue());
            Console.WriteLine(st1.GetLength());
            Console.WriteLine(st2.GetValue());
            Console.WriteLine(st2.GetLength());
            
        }
    }
}