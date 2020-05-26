using System;

namespace CSharp
{
    public class Task
    {
        public delegate void ArrayOperation(char[] ls);
        public delegate void SortArray();

        private char[] ls;

        public Task(char[] ls)
        {
            this.ls = ls;
        }

        public static void PrintArray(char[] ls)
        {
            foreach (var c in ls)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }

        public void SortByDescendning() => Array.Sort(this.ls, (c1, c2) => c2.CompareTo(c1));
        public static void SortByDescending(char[] ls) => Array.Sort(ls, (c1, c2) => c2.CompareTo(c1));
    }
}