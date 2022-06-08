using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
     static class Program
     {
        static void Main(string[] args)
        {
            Operations operation = new Operations();

            Console.WriteLine("Please enter a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            int x;
            operation.Operation(out x , y: input1 );


            Console.WriteLine("Please choose a another number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            
            int z;
            operation.Operation(out x, out z, y: input2);

        }
     } 
}


//Class Method Assignment
//Perform these actions and create a console app that includes the following:

//Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
//In the Main() method, instantiate that class.
//Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.
//Create a method with output parameters.
//Overload a method.
//Declare a class to be static.

//Operations operation = new Operations();

//Console.WriteLine("Please enter a number: ");
//int userInput = Convert.ToInt32(Console.ReadLine());

//operation.Operation(userInput);