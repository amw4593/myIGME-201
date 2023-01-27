using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorNameSpace
{
    namespace Color
    {
        //
        static class ColorClass
        {
            public static String sFavColor = null;
        }
    }
}

namespace FavoriteColorAndNumber
{
    using CAlias = ColorNameSpace.Color;
    //ALL COMMENTS FOR CLASSES SHOULD LOOK LIKE THIS
    //Class: Program
    //Author: Amrit Wanasundera
    //Purpose: Console Read/Write and Exception-Handling Excercise
    //Restrictions: None
    //ADD STATIC TO ALL CLASSES AND MEHTODS


    /*
     * This is a multiline comment
     */
    static void PrintMyColor(string sColorString)
    {
        sColorString += " is your favorite color";
        Console.WriteLine(sColorString);

    } 
    
        //COMMENTS FOR METHODS SHOULD LOOK LIKE THIS
        //Method:
        //Purpose:
        //Restrictions:
        static void Main(string[] args)
        {
            int nFavNum = 0;
            string sFavNum = null;
            sFavNum = "123";

            int? npFavNum = null;

            Int32 nParentInt = 0;
            {
                nParentInt = 1;
                int myInt = 0;
                {
                    myInt = 2;
                    nParentInt = 3;
                }
            }
            Int32 nFavNumber = 0;
            Console.WriteLine("Hello World");

            //PROMPT THE USER FOR THEIR FAVORITE COLOR

            Console.Write("Enter your favorite color:/t");

            //READ FROM THE CONSOLE NAD STORE THAT IN A VARIABLE 

            CAlias.ColorClass.sFavColor = Console.ReadLine();

            //PROMPT THE USER FOR THEIR FAVORITE NUMBER 

            Console.Write("Enter your favorite number:/t");
            //1
            while (npFavNum == null)
            {
                //READ FROM THE CONSOLE AND STORE THAT IN A VARIABLE 
                sFavNum = Console.ReadLine();

                try
                {
                    nFavNum = Convert.ToInt32(sFavNum);
                }
                catch
                {
                    Console.WriteLine("Please enter an Integer");
                }
            }
            //2
            do
            {
                //READ FROM THE CONSOLE AND STORE THAT IN A VARIABLE 
                sFavNum = Console.ReadLine();

                try
                {
                    nFavNum = Convert.ToInt32(sFavNum);
                }
                catch
                {
                    Console.WriteLine("Please enter an Integer");
                }
            } while (npFavNum == null);
            //3
            bool bValid = false;
            while (!bValid)
            //while(bValid == false)
            {
                sFavNum= Console.ReadLine();
                bValid = int.TryParse(sFavNum, out nFavNum);
            }

            npFavNum = nFavNum;


            CAlias.ColorClass.sFavColor = CAlias.ColorClass.sFavColor.ToLower();
            //CHANGE TEXT TO MATCH THEIR COLOR

            //SWITCH STATEMENTS ARE VERY SIMILAR TO IF ELSE STATMENTS, BUT MUCH CLEANER
            switch (CAlias.ColorClass.sFavColor.ToLower())
            {
                case "red":
                    Console.ForegroundColor= ConsoleColor.Red;
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            };


            //OUTPUT THEIR FAVORITE COLOR AND THEIR FAVORITE NUMBER OF TIMES

            for(int i = 0; i < npFavNum; i++) 
            {
                Console.WriteLine($"Your Favorite Color is  + { CAlias.ColorClass.sFavColor + "!"}");
            }
        }
    }
}
