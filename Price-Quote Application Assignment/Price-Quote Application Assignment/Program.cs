using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else if (packageWeight < 50)
            {
                Console.WriteLine("Please enter the package width");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int packageMeasurement = packageWidth + packageHeight + packageLength;

                if (packageMeasurement > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int packageTotal = packageHeight * packageLength * packageWidth * packageWeight;

                    decimal packagePrice = packageTotal / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + packagePrice);
                    Console.ReadLine();
                }


            }
        }
    }
}
