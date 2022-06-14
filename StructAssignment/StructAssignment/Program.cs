using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 2.3m;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }

    struct Number
    {
        public decimal Amount;
    }
}

//Perform these actions and create a console app that includes the following:

//Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
//In the Main() method, create an object of data type Number and assign an amount to it.
//Print this amount to the console.

//A class is a reference type and a struct is a value type that can't inherit