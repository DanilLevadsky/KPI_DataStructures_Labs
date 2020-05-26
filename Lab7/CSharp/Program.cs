using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new LinkedList();
            ls.Push(1);
            ls.Push(4);
            ls.Push(2);
            ls.Push(6);
            ls.Push(1);
            ls.Push(5);
            ls.PrintLinkedList();
            Console.WriteLine(ls.DividedByFive());
            ls.RemoveAfterMax();
            ls.PrintLinkedList();
            Console.WriteLine(ls.Size);
            Console.WriteLine(ls[-5]);

        }
    }
}