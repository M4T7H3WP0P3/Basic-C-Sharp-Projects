using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            File.WriteAllText(@"C:\Users\matth\OneDrive\Desktop\Basic_C#_Programs\FileIOAssignment\Logs\log.text", number.ToString());

            string text = File.ReadAllText(@"C:\Users\matth\OneDrive\Desktop\Basic_C#_Programs\FileIOAssignment\Logs\log.text");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}

//Perform these actions and create a console app that includes the following:

//Asks the user for a number.
//Logs that number to a text file.
//Prints the text file back to the user.