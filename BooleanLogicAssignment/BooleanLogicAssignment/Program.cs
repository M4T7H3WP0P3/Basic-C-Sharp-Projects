using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool DUI;
            int tickets;

            const int Minimumage = 16;
            const int Maximumtickets = 3;
            const bool RequiredDUI = false; 

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI, Please answer true or false.");
            DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have");
            tickets = Convert.ToInt32(Console.ReadLine());

            bool Qualified = age >= Minimumage && tickets <= Maximumtickets && DUI == RequiredDUI;

            Console.WriteLine("Qualified? " + Qualified);

            Console.ReadLine();

            

        }
    }
}
