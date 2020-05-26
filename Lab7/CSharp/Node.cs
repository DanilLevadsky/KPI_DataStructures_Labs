namespace CSharp
{
    internal class Node
    {
        public int Data { get; }
        internal Node Next;

        public Node(int _data, Node next = null)
        {
            this.Data = _data;
            this.Next = next;
        }
    }
}