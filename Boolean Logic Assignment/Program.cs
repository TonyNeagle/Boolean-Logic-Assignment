using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the car insurance eligibility checker!"); // Welcome message
            Console.WriteLine("What is your age now?"); // Ask for age
            int age = Convert.ToInt32(Console.ReadLine());  // Convert age input to integer
            Console.WriteLine("Have you ever had a DUI (True or False)"); // Ask about DUI
            bool hasDUI = Convert.ToBoolean(Console.ReadLine()); // Convert DUI input to boolean
            Console.WriteLine("How many speeding tickets do you have?"); // Ask for number of speeding tickets
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); // Convert speeding tickets input to integer
            bool isEligible = (age > 15 && !hasDUI && speedingTickets <= 3);// Determine eligibility based on age, DUI, and speeding tickets
            Console.WriteLine("Are you eligible? " + isEligible);// Output eligibility result

            Console.ReadLine(); // Wait for user input before closing the console
        }
    }
}
