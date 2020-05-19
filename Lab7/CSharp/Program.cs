using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ls = new LinkedList();
            ls.Head = new LinkedList.Node(1);
            var node2 = new LinkedList.Node(2);
            ls.Head.Link = node2;
            var node3 = new LinkedList.Node(7);
            node2.Link = node3;
            var node4 = new LinkedList.Node(4);
            node3.Link = node4;
            var node5 = new LinkedList.Node(9);
            node4.Link = node5;
            var node6 = new LinkedList.Node(4);
            node5.Link = node6;
            ls.PrintLinkedList();
            ls.RemoveAfterMax();
            ls.PrintLinkedList();
            Console.WriteLine(ls.DividedByFive());

        }
    }
}