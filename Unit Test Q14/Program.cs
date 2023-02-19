using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY <- Missing a semi-colon, run-time error
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.);<- missing quotes, compile-time error
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine();<- sNumber needs to be initialized, run-time error
               sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } //while (int.TryParse(sNumber, out nX));<- Needs to check nY, logical Error
            while (int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            Power(nX, nY);

            Console.WriteLine("{nX}^{nY} = {nAnswer}");
        }


        //int Power(int nBase, int nExponent) <- missing static, logical error
        static int Power(int nBase, int nExponent)
        {
            //returnVal should not have a value in local scope
            int returnVal;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 1;//base case is 1 not 0 
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //logic error, should be minus not plus
                int nextVal = Power(nBase, nExponent - 1);//declared int down here becasue it was unecessay until now 

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; <- should say return, run-time error
            return returnVal;
        }
    }
}

