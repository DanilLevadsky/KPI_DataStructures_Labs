using System;
using System.Linq;

namespace CSharp
{
    public class CapitalLetter : MyString
    {
        public CapitalLetter(char[] str) : base(str)
        {
            this.Value = str.Select(char.ToUpper).ToArray();
        }
        
        public override void Insert(char elem, int index)
        {
            var newValue = new char[GetLength() + 2];
            Array.Copy(this.Value, 0, newValue, 0, GetLength());
            for (var i = index; i < Value.Length ; i++)
            {
                newValue[i + 2] = this.Value[i];
            }
            newValue[index] = '/';
            newValue[index + 1] = char.ToUpper(elem);
            this.Value = newValue;
        }
        protected internal override int GetLength() => this.Value.Length;
    }
}