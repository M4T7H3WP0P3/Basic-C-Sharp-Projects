using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Person 1");
            int p1hourRate;
            int p1hoursperWeek;

            //user input
            Console.WriteLine("Please enter the hourly rate of pay");
            p1hourRate = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the hours worked per week");
            p1hoursperWeek = int.Parse(Console.ReadLine());

            int p1weeklyPay = p1hoursperWeek * p1hourRate;

            int p1annualPay = p1weeklyPay * 52;

            Console.WriteLine("Annual salary of Person 1: " + p1annualPay);

            Console.WriteLine("Person 2");
            int p2hourRate;
            int p2hoursperWeek;

            //user input
            Console.WriteLine("Please enter the hourly rate of pay");
            p2hourRate = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the hours worked per week");
            p2hoursperWeek = int.Parse(Console.ReadLine());

            int p2weeklyPay = p2hoursperWeek * p2hourRate;

            int p2annualPay = p2weeklyPay * 52;

            Console.WriteLine("Annual salary of Person 1: " + p2annualPay);
            
            Console.WriteLine("Person 1 makes more money than Person 2");

            bool result = (p1annualPay > p2annualPay);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
