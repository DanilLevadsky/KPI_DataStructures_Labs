using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class CustomQueue<T>
    {
        public delegate void Del(QueueHandlerArgs handlerArgs);
        public event Del QueueOverloadEvent;
        
        private T[] _data;
        private int _size;
        public int Count => _size; 

        public CustomQueue(int maxSize)
        {
            this._data = new T[maxSize];
            this._size = 0;
        }
        
        public void Enqueue(T elem)
        {
            if (this._size >= this._data.Length)
            {
                QueueOverloadEvent?.Invoke(new QueueHandlerArgs("You cannot add element to a queue. It`s overflowed!", this));
                return;
            }

            this._data[this._size] = elem;
            this._size++;
        }

        public T Dequeue()
        {
            this._size--;
            var newArray = new T[this._data.Length];
            var temp = this._data[0];
            for (var i = 1; i < this._data.Length; i++)
            {
                newArray[i - 1] = this._data[i];
            }

            this._data = newArray;
            return temp;
        }

        public void PrintQueue()
        {
            for (var i = 0; i < this._size; i++)
            {
                Console.Write(this._data[i] + ( i != this.Count - 1 ? " -> " : ""));
            }

            Console.WriteLine();
        }
     
    }
}