using System;
using System.Collections.Generic;

namespace ArraysAssignment
{
    class Program
    {
        static void Main()
        {
            string[] wordArray = { "dog", "cat", "bird", "hamster", "fish", "snake" };

            Console.WriteLine("Please choose a number between 0 and 5 to display a pet");

            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput <= 5)
            {
                Console.WriteLine("The pet contained at that index is: " + wordArray[userInput]);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            int[] numbers = { 12, 43, 53, 56, 89, 23, 92 };

            Console.WriteLine("Please choose a number between 0 and 5 to display a number in the array");

            int userInput2 = Convert.ToInt32(Console.ReadLine());

            if (userInput2 <= 5)
            {
                Console.WriteLine("The number contained at that index is: " + numbers[userInput2]);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            List<string> intList = new List<string>();

            intList.Add("Hello");
            intList.Add("Bonjour");
            intList.Add("Marhaba");
            intList.Add("Shalom");
            intList.Add("Salam");

            Console.WriteLine("Please select a number between 0 and 5 to display the greeting \"Hello\" in various languages");

            int Greeting = Convert.ToInt32(Console.ReadLine());

            if (Greeting <= 5)
            {
                Console.WriteLine("The greeting contained at the index is: " + intList[Greeting]);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
            Console.ReadLine();
        }
    }
}
