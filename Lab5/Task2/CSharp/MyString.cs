using System;

namespace CSharp
{
    public class MyString
    {
        private char[] _value;
        private int Length { get; set; }

        protected internal MyString(char[] str)
        {
            this._value = str;
            this.Length = GetLength();
        }

        protected virtual int GetLength()
        {
            return _value.Length;
        }

        public virtual void Insert(char elem, int index)
        {    
            Array.Resize(ref this._value, _value.Length + 1);
            for (var i = index; i < _value.Length - 1; i++)
            {
                _value[i + 1] = _value[i];
            }

            _value[index] = elem;
        }
    }
}