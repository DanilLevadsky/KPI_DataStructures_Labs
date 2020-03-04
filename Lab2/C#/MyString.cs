using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab2
{
    public class MyString
    {
        private readonly char[] Value;

        public MyString(char[] value)
        {
            this.Value = value;
        }

        public char[] GetValue()
        {
            return this.Value;
        }
        
    }
}