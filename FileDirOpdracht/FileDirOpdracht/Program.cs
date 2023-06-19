using System.Security.Cryptography.X509Certificates;

namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Shado\\maap\\Bureaublad\\2023P4ProgCs2";
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists )
            {
                Console.WriteLine("Directory exists");
            }

            FileInfo MyInfo = new FileInfo(path);

            foreach ( FileInfo file in dir.GetFiles() )
            {
                Console.WriteLine(file.FullName);
            }
            string[] directories = Directory.GetDirectories("C:\\Users\\Shado\\maap\\Bureaublad\\2023P4ProgCs2");
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }
        }
    }
}