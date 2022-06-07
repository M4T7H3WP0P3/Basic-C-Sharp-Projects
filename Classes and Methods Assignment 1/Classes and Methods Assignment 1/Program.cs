using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();

            Console.WriteLine("Please pick an integer: ");

            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number plus 20 =: " + operation.Operations(userInput));


            Console.WriteLine("Please pick a decimal number: ");

            double userInput2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"95.3 minus your number =: {operation.Operations(userInput2)}");

            Console.WriteLine("Please input a number: ");

            string userInput3 = Console.ReadLine();

            Console.WriteLine($"Your number multipled by 34 =: {operation.Operations(userInput3)}");
            Console.ReadLine();
        }
    }
}
