using System;
using System.IO;

namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringsplit.txt");

            string[] keyValue = content.Split(':');
            Console.WriteLine(keyValue[0]);

            string[] keyvalue2 = keyValue[1].Split(",");
            foreach (string item in keyvalue2)
            {
                string trimmedItem = item.Trim();
                if (!string.IsNullOrEmpty(trimmedItem))
                    Console.WriteLine(trimmedItem);
            }
        }
    }
}
