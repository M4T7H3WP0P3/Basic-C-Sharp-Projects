using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);

            //Asks the user for a number.
            Console.ReadLine();
            Console.WriteLine("Please pick a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            var today = DateTime.Now;
            
            var time = DateTime.Now + TimeSpan.FromHours(userInput);

            Console.WriteLine($"{userInput} hours from now would be: {time}");
            Console.ReadLine();
            //DateTime combined = date1 + Hours(userInput);



            //DateTime time = DateTime.Now.Add(userInput);

            //Console.WriteLine(userInput);



            //Console.WriteLine($"{userInput} hours from now would be.." + DateTime.Now + Convert.ToDateTime(userInput));
            //Console.ReadLine();
        }
    }
}

//Perform these actions and create a console app that includes the following:



