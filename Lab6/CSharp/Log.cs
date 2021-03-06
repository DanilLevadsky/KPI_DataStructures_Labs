using System.IO;
using System;

namespace CSharp
{
    public class Log
    {
        public static void LogException(params Exception[] e)
        {
            const string fileName = "/Users/danillevadsky/RiderProjects/KPILabs/Lab6/CSharp/exceptions.log";

            void WriteToFile(TextWriter sw)
            {
                foreach (var exc in e)
                {
                    sw.Write($"{DateTime.Now}: {exc.ToString()}\n\n");
                }
            }
            if (!File.Exists(fileName))
            {
                using var sw = new StreamWriter(fileName);
                sw.WriteLine($"Created date: {DateTime.Now}\n");
                WriteToFile(sw);
            }
            else
            {
                using var sw = File.AppendText(fileName);
                WriteToFile(sw);
            }
        }
    }
}