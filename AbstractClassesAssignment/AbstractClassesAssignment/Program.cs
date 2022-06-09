using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = ("Sample");
            employee.lastName = ("Student");

            employee.SayName();
            Console.ReadLine();

        }
    }
}
//Perform these actions and create a console app that includes the following:

//Create an abstract class called Person with two properties: string firstName and string lastName.
//Give it the method SayName().
//Create another class called Employee and have it inherit from the Person class.
//Implement the SayName() method inside of the Employee class.
//Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.