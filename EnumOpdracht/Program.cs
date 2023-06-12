using System.Drawing;
using System.Runtime.InteropServices;

namespace EnumOpdracht
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Colors myMainThemeColor = Colors.white;

            if (myMainThemeColor == Colors.white )
            {
                Console.WriteLine("Dat is mijn kleur!");
            }

            Console.ReadLine();
        }
    }

}