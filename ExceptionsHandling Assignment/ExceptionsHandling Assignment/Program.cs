using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHandling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you age:");

            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0 || age < 0)
                {
                    throw new OverflowException();
                }
                int birthYear = DateTime.Now.Year - age;
                Console.WriteLine("You were born in {0}", birthYear);
            }
            catch(OverflowException)
            {
                Console.WriteLine("Your age can not be zero, or less than zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            Console.ReadLine();
        }
    }
}

//Perform these actions and create a console app that includes the following:

//Ask the user for their age.
//Display the year the user was born.
//Exceptions must be handled using “try/catch.”
//Display appropriate error messages if the user enters zero or negative numbers.
//Display a general message if an exception was caused by anything else.