using System;
using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("leesdezefile.txt");
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
            string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "output");

            Directory.CreateDirectory(outputDirectory);

            string outputPath = Path.Combine(outputDirectory, "mijnnieuwefile.txt");

            File.WriteAllText(outputPath, "dit is een nieuwe file.");

            File.AppendAllText(outputPath, Environment.NewLine + "dit is een extra zin.");

        }

    }
}
