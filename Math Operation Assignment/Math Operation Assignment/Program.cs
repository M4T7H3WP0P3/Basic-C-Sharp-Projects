using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Multiplying by 50

            //variables
            int Multiply;
            int numtoMultiply;
            Multiply = 50;

            //user input
            Console.WriteLine("Please enter a number to be multipled by 50");

            numtoMultiply = int.Parse(Console.ReadLine());

            int totalMulti = numtoMultiply * Multiply;

            Console.WriteLine("Your number multiplied by 50 = " + totalMulti);
            Console.ReadLine();

            //Adding 25

            //variables
            int Addition;
            int numtoAdd;
            Addition = 25;

            //user input
            Console.WriteLine("Please enter a number and we will add 25 to it");

            numtoAdd = int.Parse(Console.ReadLine());

            int totalAdd = numtoAdd + Addition;

            Console.WriteLine("25 plus your number = " + totalAdd);
            Console.ReadLine();

            //Divided by 12.5

            //variables
            double divide;
            int numtoDivide;
            divide = 12.5;

            //user input
            Console.WriteLine("Please enter a number to be divided by 12.5");

            numtoDivide = int.Parse(Console.ReadLine());

            double totalDivide = numtoDivide / divide;

            Console.WriteLine("Your number divided by 12.5 = " + totalDivide);
            Console.ReadLine();

            //Greater than 50
            Console.WriteLine("Write your number to see if it is greater than 50:");
            int n = int.Parse(Console.ReadLine());

            bool result = (n > 50);
            Console.WriteLine(result);
            Console.ReadLine();


            //Finding the remainder

            //variables
            double divisor;
            double dividend;
            divisor = 7;

            //user input
            Console.WriteLine("Please enter a number to be divided by 7 to find the remainder");

            dividend = double.Parse(Console.ReadLine());

            double remainder = dividend % divisor;

            Console.WriteLine("The remainder is " + remainder);
            Console.ReadLine();
                      
        }
    }
}
