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
            Console.WriteLine("Welcome to the car insurance eligibility checker!");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI (True or False");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            bool isEligible = (age > 15 && !hasDUI && speedingTickets <= 3);
            Console.WriteLine("Are you eligible? " + isEligible);

            Console.ReadLine();
        }
    }
}
