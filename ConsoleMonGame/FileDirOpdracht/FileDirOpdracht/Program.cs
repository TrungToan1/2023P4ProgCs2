namespace FileDirOpdracht
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\Shado\\maap\\Bureaublad\\2023P4ProgCs2");

            DirectoryInfo[] directories = dir.GetDirectories();
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine(directories[i].FullName);
             
            }


            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i].FullName);
            }

        }

    }
}