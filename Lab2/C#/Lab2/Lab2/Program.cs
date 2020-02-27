using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var abs = "13123zxfas".ToCharArray(); 
            var str1 = new MyString(abs);
            Console.WriteLine(str1.Value);
            var text = new MyText();
            
        }
    }
}