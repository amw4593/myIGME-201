using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            Console.WriteLine(randomNumber.ToString());

            for(int i = 0; i < 8; i++) 
            {
                Console.Write("Pick a Number Between 1 and 100: ");
                Console.ReadLine(randomNumber);
            }
        }
    }
}
