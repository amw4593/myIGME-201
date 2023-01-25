using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wanasundera_HelloWorld
{
    //Class: Program
    //Author: Amrit Wanasundera
    //Purpose: Write Hello World and Experiment with C#
    //Restrictions: None

    static internal class Program
    {
        //Method: Main
        //Purpose: Write 'hello world' and experiment with variables and calculations
        //Restrictions: None
        static void Main(string[] args)
        {
            //Make background color dark ble 
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //write hello world and my name 
            Console.WriteLine("Hello World");
            Console.WriteLine("Amrit Wanasundera");
            //set a variable
            int x = 8;
            //make a random calculation and console it 
            int calculation1 = (20 * 6/x) / 100 + 56 * (23+x);
            Console.WriteLine(calculation1);
        }
    }
}
