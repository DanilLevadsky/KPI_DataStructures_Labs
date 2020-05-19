using System;
using System.Data;

namespace CSharp
{
    public class LinkedList
    {
        public Node Head;
        
        public class Node
        {
            public int Data { get; }
            public Node Link;

            public Node(int _data)
            {
                this.Data = _data;
                this.Link = null;
            }
        }

        public int DividedByFive()
        {
            var counter = 0;
            var foo = Head;
            while (foo != null)
            {
                if (foo.Data % 5 == 0)
                {
                    counter++;
                }
                foo = foo.Link;
            }

            return counter;
        }

        public void RemoveAfterMax()
        {
            var temp = Head;
            var maxElement = Head.Data;
            while (temp != null)
            {
                if (temp.Data > maxElement)
                {
                    maxElement = temp.Data;
                }

                temp = temp.Link;
            }


            temp = Head;
            while (temp != null)
            {
                if (temp.Data == maxElement)
                {
                    temp.Link = null;
                }
                temp = temp.Link;
            }

        }

        public void PrintLinkedList()
        {
            var foo = Head;
            while (foo != null)
            {
                Console.Write(foo.Data + " -> ");
                foo = foo.Link;
            }

            Console.WriteLine( "null");
        }
        
    }
}