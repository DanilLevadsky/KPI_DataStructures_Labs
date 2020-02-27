using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class MyText
    {
        private MyString[] Value;
        private int[] ArrOfLength;

        public MyText()
        {
            this.Value = new MyString[0];
            this.ArrOfLength = new int[0];
        }

        public void AddString(MyString myString)
        {
            Array.Resize(ref Value, Value.Length + 1);
            Value[^1] = myString;
            Array.Resize(ref ArrOfLength, ArrOfLength.Length + 1);
            ArrOfLength[^1] = myString.StringLength;
        }

        public void Read()
        {
            foreach (var myString in this.Value)
            {
                foreach (var character in myString.Value)
                {
                    Console.Write(character);
                }

                Console.Write(' ');
            }

            Console.WriteLine();
        }

        public void RemoveString(int index)
                 {
                     var temp = new MyString[Value.Length - 1];
                     var arrOfLength = new int[ArrOfLength.Length - 1];
                     for (var i = 0; i < Value.Length; i++)
                     {
                         if (i < index)
                         {
                             temp[i] = Value[i];
                             arrOfLength[i] = ArrOfLength[i];
                         }
         
                         if (i == index) { continue; }
                         if (i > index)
                         {
                             temp[i-1] = Value[i];
                             arrOfLength[i - 1] = ArrOfLength[i];
                         }
                     }
                     
                     Value = temp;
                     ArrOfLength = arrOfLength;
                 }

        public void EraseText()
        {
            this.Value = new MyString[0];
            this.ArrOfLength = new int[0];
        }

        public double AverageLength()
        {
            if (ArrOfLength.Length == 0) { return 0; }
            var sum = ArrOfLength.Sum(number => (double) number);
            return (sum / ArrOfLength.Count());
            
        }

        public double PercentOfVowel()
        {
            double letters = 0;
            double vowel = 0;
            foreach (var array in this.Value)
            {
                foreach (var letter in array.Value)
                {
                    letters++;
                    if ("eyuioaEYUIOA".Contains(letter) == true)
                    {
                        vowel++;
                    }
                }
            }

            return (vowel / letters) * 100;
        }

        public void RemoveString(string substring)
        {
            var subArray = substring.ToCharArray();
            foreach (var arr in this.Value)
            {
                
            }
        }
        
    }
}