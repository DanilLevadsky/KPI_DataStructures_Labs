using System;

namespace CSharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Task 1
            var arr = "qwertyuiop".ToCharArray();
            Task.ArrayOperation sortByDescending = Task.SortByDescending;
            sortByDescending += Task.PrintArray;
            sortByDescending(arr);

            // Task 2
            var q = new CustomQueue<int>(2);
            q.QueueOverloadEvent += QueueOverflowHandler;
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.PrintQueue();
            q.Dequeue();
            q.PrintQueue();
            q.Enqueue(8);
            q.Enqueue(9);
            q.PrintQueue();
            
        }

        private static void QueueOverflowHandler(QueueHandlerArgs handlerArgs) => Console.WriteLine(handlerArgs.Message);

       
    }
    
}