using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Please pick a number that we will use in our math operations");
            int userInp = Convert.ToInt32(Console.ReadLine());

            Integers obj1 = new Integers();

            Console.WriteLine("Your number multiplied by 5 is " + obj1.MultiplyTwoNumbers(userInp));
            Console.WriteLine("Your number added to 10 is " + obj1.AddTwoNumbers(userInp));
            Console.WriteLine("50 divided by your number is " + obj1.DivideTwoNumbers(userInp));
            Console.ReadLine();
            //int num1 = 5;
            //int num2 = 8;
            //int num3 = 50;

            //Console.WriteLine("Please pick a number that we will use in our math operations");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //Integers.AddTwoNumbers();

        }                    
        
    }
}
