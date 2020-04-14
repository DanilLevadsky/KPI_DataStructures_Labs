using System;

namespace CSharp
{
    public class MyString
    {
        protected char[] Value;
        public string GetValue() => string.Join("", Value);

        public MyString(char[] str)
        {
            this.Value = str;
        }

        protected internal virtual int GetLength()
        {
            return this.Value.Length;
        }

        public virtual void Insert(char elem, int index)
        {    
            var newValue = new char[GetLength() + 1];
            Array.Copy(this.Value, 0, newValue, 0, GetLength());
            for (var i = index; i < Value.Length; i++)
            {
                newValue[i + 1] = Value[i];
            }

            newValue[index] = elem;
            this.Value = newValue;
        }
    }
}