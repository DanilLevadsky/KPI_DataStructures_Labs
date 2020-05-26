using System;
using System.Data;

namespace CSharp
{
    public class LinkedList
    {
        private Node _head;
        private Node _current;
        public int Size { get; private set; }

        public LinkedList()
        {
            _head = null;
            Size = 0;
        }

        public void Push(int value)
        {
            if (_head == null)
            {
                _head = new Node(value);
                _current = _head;
                Size++;
                return;
            }
            var newNode = new Node(value);
            _current.Next = newNode;
            _current = newNode;
            Size++;
        }
        
        public int DividedByFive()
        {
            var counter = 0;
            _current = _head;
            while (_current != null)
            {
                if (_current.Data % 5 == 0)
                {
                    counter++;
                }
                _current = _current.Next;
            }

            return counter;
        }

        public void RemoveAfterMax()
        {
            
            _current = _head;
            var maxElement = _head.Data;
            while (_current != null)
            {
                if (_current.Data > maxElement)
                {
                    maxElement = _current.Data;
                }

                _current = _current.Next;
            }


            _current = _head;
            Size = 0;
            while (_current != null)
            {
                if (_current.Data == maxElement)
                {
                    _current.Next = null;
                }
                _current = _current.Next;
                Size++;
            }
        }

        public int? this[int index]
        {
            get
            {
                if (index < 0 || index >= Size)
                {
                    Console.WriteLine("Out of range.");
                    return null;
                }

                var i = 0;
                _current = _head;
                while (i != index)
                {
                    _current = _current.Next;
                    i++;
                }
                
                return _current.Data;
            }
        }

        public void PrintLinkedList()
        {
            _current = _head;
            while (_current != null)
            {
                Console.Write(_current.Data + " -> ");
                _current = _current.Next;
            }

            Console.WriteLine( "null");
        }
        
    }
}