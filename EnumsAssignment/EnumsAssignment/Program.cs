using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
   
    class Program
    {
        public enum DaysoftheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
        public static void Main(string[] args)
        {
            try
            {   
               
                Console.WriteLine("Please enter the current day of the week");
                string userDay = Console.ReadLine();
                DaysoftheWeek day = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), userDay);
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Please enter an actual day of the week {ex}");
                
            }
            Console.ReadLine(); 
            
            
               
        } 
        
    }
 
 
}
//NOTE: To complete this assignment, you will need to do some online research on how to parse enums.

//Perform these actions and create a console app that includes the following:

//Create an enum for the days of the week.
//Prompt the user to enter the current day of the week.
//Assign the value to a variable of that enum data type you just created.
//Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

//enums = special "class" that contains a set of named integer constants.
//Use enums when you have values that you know will not change, 
//To get the integer value from an item, you must explicitly convert to an int

//enum DaysoftheWeek
//{
//    Sunday,
//    Monday,
//    Tuesday, 
//    Wednesday, 
//    Thursday, 
//    Friday, 
//    Saturday,       
//}

//try
//{
//    DaysoftheWeek daysoftheWeek = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek);
//}
//Console.WriteLine("Please enter the current day of the week");

//string userInput = Console.ReadLine();

//string[] colorStrings = { "0", "2", "8", "blue", "Blue", "Yellow", "Red, Green" };
//foreach (string colorString in colorStrings)
//{
//    try
//    {
//        DaysoftheWeek colorValue = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), colorString);
//        if (Enum.IsDefined(typeof(DaysoftheWeek), colorValue) | colorValue.ToString().Contains(","))
//            Console.WriteLine("Converted '{0}' to {1}.", colorString, colorValue.ToString());
//        else
//            Console.WriteLine("{0} is not an underlying value of the Colors enumeration.", colorString);
//    }
//    catch (ArgumentException)
//    {
//        Console.WriteLine("'{0}' is not a member of the Colors enumeration.", colorString);
//    }
//}

//foreach (DaysoftheWeek days in Enum.GetValues(typeof(DaysoftheWeek)))
//{
//    Console.WriteLine(days.ToString());
//}
//try
//{
//    Console.WriteLine("Please enter the current day of the week");
//    string userInput = (string)Enum.Parse(typeof(string);

//}




//DaysoftheWeek day = (DaysoftheWeek)Convert.ToInt32(userInput);

//Console.WriteLine($"Your chose {userInput}");
//Console.ReadLine();