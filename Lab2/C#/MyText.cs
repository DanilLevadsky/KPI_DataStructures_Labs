using System;
using System.Linq;

namespace Lab2
{
    public class MyText
    {
        private MyString[] Value;
        
        public MyText()
        {
            this.Value = new MyString[0];
        }

        public void AddString(MyString myString)
        {
            Array.Resize(ref Value, Value.Length + 1);
            Value[^1] = myString;
        }

        public void Write()
        {
            foreach (var myString in this.Value)
            {
                foreach (var character in myString.GetValue())
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
                     for (var i = 0; i < Value.Length; i++)
                     {
                         if (i < index)
                         {
                             temp[i] = Value[i];
                         }
         
                         if (i == index) { continue; }
                         if (i > index)
                         {
                             temp[i-1] = Value[i];
                         }
                     }
                     
                     Value = temp;
                 }

        public void EraseText()
        {
            this.Value = new MyString[0];
        }

        public double AverageLength()
        {
            if (Value.Length == 0) { return 0; }

            var result = (double) this.Value.Sum(myString => myString.GetValue().Length) / this.Value.Length;
            return result;
            
        }

        public double PercentOfVowel()
        {
            double letters = 0;
            double vowel = 0;
            foreach (var array in this.Value)
            {
                foreach (var letter in array.GetValue())
                {
                    letters++;
                    if ("eyuioaEYUIOA".Contains(letter))
                    {
                        vowel++;
                    }
                }
            }

            return (vowel / letters) * 100;
        }

        public void RemoveString(string substring)
        {
            for (var index = 0; index < this.Value.Length; index++)
            {
                var str = this.Value[index];
                for (var i = 0; i < str.GetValue().Length; i++)
                {
                    if (str.GetValue()[i] != substring[0]) continue;
                    var counter = 0;
                    for (var x = 0; x < substring.Length; x++)
                    {
                        if (str.GetValue()[i + x] != substring[x])
                        {
                            break;
                        }

                        counter++;
                    }

                    if (counter != substring.Length) continue;
                    RemoveString(index);
                    index--;
                }
            }
        }
        
    }
}