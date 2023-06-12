using System.Diagnostics;

namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");


            List<string> birds = new List<string>();
            birds.Add("Uil");
            birds.Add("Kraai");
            birds.Add("Hond");
            birds.Add("Papegaai");

            List<string> birds2 = new List<string>();
            birds.Add("Meeuw");
            birds.Add("Duif");

            birds.Remove("Hond");


            birds.AddRange(birds2);
            Console.WriteLine(birds);


            for (int i = 0; i < birds.Count; i++)
            {
                Console.WriteLine(birds[i]);
              
            }
            Console.ReadLine();

        }
    }
}
