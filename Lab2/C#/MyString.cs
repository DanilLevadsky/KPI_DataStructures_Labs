using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab2
{
    public class MyString
    {
        public readonly char[] Value;
        public int StringLength;

        public MyString(char[] value)
        {
            this.Value = value;
            this.StringLength = this.Value.Length;
        }
        
    }
}