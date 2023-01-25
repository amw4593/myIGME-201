using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare int counter
            //Missing a semi-colon
            //int i = 0 //syntax error 
            int i = 0;

            // loop through the numbers 1 through 10
            //displays 1-9 and we want it to show up to 10
            //for (i = 1; i < 10; ++i)
            for (i = 1; i < 11; ++i)
                {
                // declare string to hold all numbers
                string allNumbers = null;

                // output explanation of calculation
                //comma after backslash
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/", i - 1 + " = ");

                // output the calculation based on the numbers
                //calculation divides by zero
               Console.WriteLine(i/i - 1);

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //increment counter using i++
                //i = i + 1;//logic error as the code will add once
                i++;
                Console.WriteLine("These numbers have been processed: " + allNumbers);
            }

            // output all numbers which have been processed
            // wrong scope; should be in for loop
            // missing a plus sign which breaks the code as it has no idea what to do 
            //Console.WriteLine("These numbers have been processed: " allNumbers); //syntax+logic error
        }
    }
}

