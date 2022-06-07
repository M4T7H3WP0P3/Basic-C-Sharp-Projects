using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();

                       
            Console.WriteLine("Please input a number: ");

            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input another number: if no number is selected, the default number used will be 3. ");

            try
            {
                int userInput2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Your two numbers multiplied together = {operation.Operations(userInput1, userInput2)}");
            }
            catch
            {
                Console.WriteLine($"Your one number multiplied with 3 = {operation.Operations(userInput1)}");
            }
            finally
            {
                Console.ReadLine();
            }       
                   
        }
    }
}
//Perform these actions and create a console app that includes the following:

//Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.
//In the Main() method of the console app, instantiate the class.
//Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
//Call the method in the class, passing in the one or two numbers entered.
//Try various combinations of numbers on the code, including having no second number.
