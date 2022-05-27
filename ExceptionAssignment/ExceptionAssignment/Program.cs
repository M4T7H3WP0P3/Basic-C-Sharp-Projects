using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 9, 41, 13, 23, 53, 34, 68 };

            int index = 0;
            while (index < 6)
            {
                try
                {
                    for (index = 0; index < numbers.Count; index++)
                    {
                        Console.WriteLine("Please pick a number to have divided by each number in the list");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dividing the numbers...");
                        int num2 = numbers[index] / num1;
                        Console.WriteLine(num2);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please type a whole number");
                    continue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please don't divide by zero");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                finally
                {
                    Console.ReadLine();                   
                }                
            }

        }
    }
}
