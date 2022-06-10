using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Matthew");

            Employee e2 = new Employee(2, "John");
            //e1.Display();

            if (e1 == e2)
            {
                Console.WriteLine(e1 == e2);

            }
            else
            {
                Console.WriteLine(e1 != e2);
            }
            
            Console.ReadLine();












        }
    }
}
//Perform these actions and create a console app that includes the following:

//Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.


//Employee employee = new Employee();
//employee.ID = new List<Employees>;
//Employee employees = new Employees();
//employee.firstName = "Matthew";
//employee.lastName = "Pope";
//employee.ID = 1;

//employee.firstName = "John";
//employee.lastName = "Cena";
//employee.ID = 2;

//Console.WriteLine();