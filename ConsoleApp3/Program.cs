using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();

    // Add some friends and their birthdays to the SortedList
friendBirthdays.Add("Alice", new DateTime(1990, 4, 15));
friendBirthdays.Add("Bob", new DateTime(1992, 8, 1));
friendBirthdays.Add("Charlie", new DateTime(1988, 12, 25));
friendBirthdays.Add("David", new DateTime(1995, 3, 22));

// Loop through each element in the SortedList and output the friend's name and birthday
foreach (KeyValuePair<string, DateTime> friend in friendBirthdays)
{
    Console.WriteLine("{0} was born on {1}", friend.Key, friend.Value.ToString("MM/dd/yyyy"));
}

