using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UnitTestQ12
{
    internal class Program
    {
        //12
        static void Main()
        {
            string sName;
            double dSalary = 30000;

            Console.Write("Enter your name: ");
            sName = Console.ReadLine();

            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congrats, You Recieved A Raise");
            }
            else
            {
                Console.WriteLine("Unfortunately, You Didn't Get That Raise");
            }

            Console.WriteLine("Your new salary is: $" + dSalary);
        }
        static bool GiveRaise(string name, ref double salary)
        {
            const string userName = "Name";
            const double salInc = 19999.99;
            if (name == userName)
            {
                salary += salInc;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}