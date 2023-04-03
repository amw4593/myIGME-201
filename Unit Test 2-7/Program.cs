using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_2_7
{
    public interface IPhone
    {
        void MakeCall();
        void HangUp();
    }

    public class Tardis : IPhone
    {
        public void MakeCall()
        {
            // implementation for making a call using Tardis
            Console.WriteLine("Dialing the phone in the Tardis...");
        }

        public void HangUp()
        {
            // implementation for hanging up a call using Tardis
            Console.WriteLine("Hanging up the phone in the Tardis...");
        }
    }

    public class PhoneBooth : IPhone
    {
        public void MakeCall()
        {
            // implementation for making a call using PhoneBooth
            Console.WriteLine("Dialing the phone in the PhoneBooth...");
        }

        public void HangUp()
        {
            // implementation for hanging up a call using PhoneBooth
            Console.WriteLine("Hanging up the phone in the PhoneBooth...");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);
        }

        public static void UsePhone(object obj)
        {
            IPhone phone = obj as IPhone;

            if (phone != null)
            {
                phone.MakeCall();
                phone.HangUp();

                if (obj is PhoneBooth)
                {
                    PhoneBooth phoneBooth = obj as PhoneBooth;
                    phoneBooth.OpenDoor();
                }
                else if (obj is Tardis)
                {
                    Tardis tardis = obj as Tardis;
                    tardis.TimeTravel();
                }
            }
        }
    }

}

