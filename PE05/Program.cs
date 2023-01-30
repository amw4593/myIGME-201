using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 15;
            int operand2 = 12;
            if (operand1 >= 10 && operand2 >= 10)
            {
                Console.WriteLine("Enter New Numbers!");
            }
                Console.WriteLine("Operand1: ");
            if (operand1 >= 10){
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("Operand2: ");
            if (operand2 >= 10){
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            };

        }
    }
}
