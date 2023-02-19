using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_Q13
{
    internal class Program
    {
          //13
struct employee
        {
            public string sName;
            public double dSalary;
        }
        static bool GiveRaise(string name, ref double salary)
        {
            if (name == "your name")
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string sName = Console.ReadLine();

            employee emp = new employee
            {
                sName = sName,
                dSalary = 30000
            };

            bool gotRaise = GiveRaise(emp.sName, ref emp.dSalary);

            if (gotRaise)
            {
                Console.WriteLine("Congratulations, you got a raise!");
            }
            else
            {
                Console.WriteLine("Sorry, you didn't get a raise.");
            }

            Console.WriteLine($"Your new salary is: ${emp.dSalary}");
        }
    }


}
