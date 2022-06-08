using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();


            Console.WriteLine("Pick choose a number:");

            int userInput = Convert.ToInt32(Console.ReadLine()); //Takes users input and assigns it to int variable userInput

            Console.WriteLine("Pick another number: ");

            int userInput2 = Convert.ToInt32(Console.ReadLine()); //Takes users input and assigns it to int variable userInput2

            class1.Operation(userInput, userInput2); //Calls the method, passing in two numbers

            class1.Operation(x: userInput , y: userInput2); //Calls the method, specifying the parameters by name. 
            


        }
    }
}

//Perform these actions and create a console app that includes the following:

//Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.
//In the Main() method of the console app, instantiate the class.
//Call the method in the class, passing in two numbers.
//Call the method in the class, specifying the parameters by name.
//Upload your code to GitHub and paste the link in the space below: