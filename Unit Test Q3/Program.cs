using System;

namespace RoundDelegateExample
{
    //class program
 //delegate function
 //main will allow delegate function to round numbers to 2 digits 
    class Program
    {
        delegate double RoundDelegate(double value, int digits);

        static void Main(string[] args)
        {
            // Round Delegate will round the value
            RoundDelegate roundDelegate = Math.Round;

            // Round to 2 decimal places
            double rounded = roundDelegate(3.14159, 2);
            Console.WriteLine($"Rounded value: {rounded}");
        }
    }
}
