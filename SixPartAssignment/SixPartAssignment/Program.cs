using System;
using System.Collections.Generic;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1

            string[] titles = { "sir ", "lord ", "mr ", };
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            for (int i = 0; i < titles.Length; i++)
            {
                titles[i] = titles[i] + lastName;
                Console.WriteLine(titles[i]);
                Console.ReadLine();
            }



            //Part 2
            //infinite loop
            //int count = 0;

            //while(true)
            //{
            //    Console.WriteLine("Count = {0}.", count);

            //    if (count > 125)
            //    {
            //        break;
            //    }
            //}

            //fixed infinite loop

            int count2 = 0;

            while (true)
            {
                Console.WriteLine("Count = {0}.", count2);
                count2++;

                if (count2 > 125)
                {
                    break;
                }
            }
            Console.ReadLine();
            //Part 3
            // < comparison
            int numbers = 0;

            while (numbers < 5)
            {
                Console.Write(numbers + " ");
                numbers++;
            }
            Console.ReadLine();

            // <= comparison
            int n = 1;

            while (n <= 8)
            {
                Console.Write(n + " ");
                n++;
            }
            Console.ReadLine();

            //Part 4
            List<string> animals = new List<string>();
            animals.Add("dog");
            animals.Add("cat");
            animals.Add("bird");
            animals.Add("hamster");
            animals.Add("snake");
            animals.Add("lizard");

            Console.WriteLine("Please enter a type of pet to receive the index number: ");

            string userInput = Console.ReadLine();

            int index = animals.FindIndex(a => a.Contains(userInput));

            foreach (string animal in animals)
            {
                if (userInput == animal)
                {
                    Console.WriteLine(userInput + " is found at index: " + index);
                    break;
                }
                else
                {
                    Console.WriteLine("That option is not in this list");                    
                }
            }
            Console.ReadLine();

            //Part 5
            List<string> names = new List<string>();
            names.Add("matthew");
            names.Add("nathan");
            names.Add("john");
            names.Add("joe");
            names.Add("matthew");

            Console.WriteLine("Please enter one of the following names: matthew, nathan, john, joe ");

            string userInput2 = Console.ReadLine();

            //int namesindex = names.FindIndex(b => b.Contains(userInput2));

            for (int i = 0; i < names.Count; i++) //goes through the list and shows both index numbers of matthew
            {
                if (userInput2 == names[i])
                {
                    Console.WriteLine(userInput2 + " is found at index: " + i);                    
                }
                else
                {
                    Console.WriteLine("The name you have enter is not in the list");
                }
            }
            
            //Part 6
            List<string> cars = new List<string>() { "nissan", "honda", "toyota", "ford", "chevrolet", "gmc", "nissan" };
            List<string> carMakes = new List<string>();


            foreach (string car in cars)
            {
                if (!carMakes.Contains(car)) //checks if car has not appeared in carMakes list
                {
                    carMakes.Add(car);
                    Console.WriteLine(car + " has not appeared. ");
                }
                else if (carMakes.Contains(car)) //if car appears in carMakes list Console.Write will appear
                {
                    Console.WriteLine(car + " has appeared in list. ");
                }
            }
            Console.ReadLine();
        }
    }
}
