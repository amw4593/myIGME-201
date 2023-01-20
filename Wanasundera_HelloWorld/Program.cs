using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wanasundera_HelloWorld
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Amrit Wanasundera");
            int x = 8;
            int calculation1 = (20 * 6/x) / 100 + 56 * (23+x);
            Console.WriteLine(calculation1);
        }
    }
}
