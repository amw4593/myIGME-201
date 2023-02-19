using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5
            double[,,] computations = new double[3, 3, 3];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        computations[x, y, z] = x + y + z;
                    }
                }
            }
            //7
            Console.WriteLine("Enter a string: ");
            string reverso = Console.ReadLine();

            char[] charArray = reverso.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine("Reversed string: ");
            Console.WriteLine(new string(charArray));
    
            //8
            Console.WriteLine("Enter a string: ");
            string noYes = Console.ReadLine();

            string output = noYes.Replace("no", "yes");
            noYes.CompareTo(output);
            //for each with .split()
            Console.WriteLine("Result: ");
            Console.WriteLine(output);

            //9
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Console.WriteLine("Result: ");
            foreach (string word in words)
            {
                Console.Write("\"" + word + "\" ");
            }
        }
    }
}
