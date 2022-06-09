using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = ("Matthew");
            person.lastName = ("Pope");
            person.SayName();

            Employee employee = new Employee();
            employee.firstName = ("Sample");
            employee.lastName = ("Student");
            employee.SayName();
            Console.ReadLine();
            
        }
    }
}
//Perform these actions and create a console app that includes the following:

//Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.
//Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]".
//Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
//Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student".
//Call the superclass method SayName() on the Employee object.