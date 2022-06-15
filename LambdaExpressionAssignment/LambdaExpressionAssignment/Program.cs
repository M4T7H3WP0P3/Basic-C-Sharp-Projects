using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    public class Program
    {
        public class Employee
        {
            public string firstName;
            public string lastName;
            public int empId;

            public Employee(string xfName, string xlName, int xID)
            {
                firstName = xfName;
                lastName = xlName;
                empId = xID;
            }
        }

        static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:

            //In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Matthew ", "Pope", 1));
            employees.Add(new Employee("Allen ", "Iverson", 2));
            employees.Add(new Employee("Jesse ", "Johnson", 3));
            employees.Add(new Employee("Israel ", "Adensanya", 4));
            employees.Add(new Employee("Kamaru ", "Usman", 5));
            employees.Add(new Employee("Barack ", "Obama", 6));
            employees.Add(new Employee("Donald ", "Trump", 7));
            employees.Add(new Employee("Joe", "Sakic", 8));
            employees.Add(new Employee("Joe", "Mama", 9));
            employees.Add(new Employee("John ", "Cena", 10));

            //Using a foreach loop, create a new list of all employees with the first name "Joe".

            //List<string> joeList = new List<string>();

            //foreach(Employee employee in employees)
            //{
            //    if (employee.firstName.Contains("Joe"))
            //    {
            //        joeList.Add(employee.firstName);
            //        Console.WriteLine(employee.firstName + "" +employee.lastName); 
            //    }
            //}           
            //Console.ReadLine();

            //Perform the same action again, but this time with a lambda expression.

            //List<Employee> lambList = employees.Where(e => e.firstName == "Joe").ToList();



            //foreach(Employee employee in lambList)
            //{
            //    Console.WriteLine(employee.firstName + " " + employee.lastName);
            //}

            //Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> empId = employees.Where(x => x.empId > 5).ToList();

            foreach(Employee employee in empId)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.empId);
            }

            Console.ReadLine();
        }
    }
}


//Notes
//we can't put the list name in the WriteLine() because it won't print off the contents, just the list object itself.

