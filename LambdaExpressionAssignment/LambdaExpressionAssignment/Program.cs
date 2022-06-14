using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            employees.Add(new Employees()
            {
                Id = 1,
                firstName = "Matthew",
                lastName = "Pope"
            });

            employees.Add(new Employees()
            {
                Id = 2,
                firstName = "John",
                lastName = "Cena"
            });
            employees.Add(new Employees()
            {
                Id = 3,
                firstName = "Joe",
                lastName = "Mama"
            });
            employees.Add(new Employees()
            {
                Id = 4,
                firstName = "Joe",
                lastName = "Sakic"
            });
            employees.Add(new Employees()
            {
                Id = 5,
                firstName = "Jesse",
                lastName = "Johnson"
            });
            employees.Add(new Employees()
            {
                Id = 6, 
                firstName = "Brett",
                lastName = "Favre"
            });
            employees.Add(new Employees()
            {
                Id = 7, 
                firstName = "Barack", 
                lastName = "Obama"
            });
            employees.Add(new Employees()
            {
                Id = 8,
                firstName = "Donald",
                lastName = "Trump"
            });
            employees.Add(new Employees()
            {
                Id = 9, 
                firstName = "Naruto",
                lastName = "Uzumaki"
            });
            employees.Add(new Employees()
            {
                Id = 10, 
                firstName = "Sasuke",
                lastName = "Uchiha"
            });
            
            foreach (Employees emp in employees)
            {
                if (emp.firstName.Contains("Joe"))
                {
                    List<string> newList = new List<string>();
                    newList.Add(emp.firstName);
                    Console.WriteLine(newList);
                }
            }
            Console.ReadLine();
            //foreach (var value in employees)
            //{
            //    var empList = value.firstName;
            //    if ()
            //}
            

        }
    }
}

//Perform these actions and create a console app that includes the following:

//In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".
//Using a foreach loop, create a new list of all employees with the first name "Joe".
//Perform the same action again, but this time with a lambda expression.
//Using a lambda expression, make a list of all employees with an Id number greater than 5.
//Upload your code to GitHub and paste the link in the space below: