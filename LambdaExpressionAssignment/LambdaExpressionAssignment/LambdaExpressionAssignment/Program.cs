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
            employees.Add(new Employee("Matthew", "Pope", 1));
            employees.Add(new Employee("Allen", "Iverson", 2));
            employees.Add(new Employee("Jesse", "Johnson", 3));
            employees.Add(new Employee("Israel", "Adensanya", 4));
            employees.Add(new Employee("Kamaru", "Usman", 5));
            employees.Add(new Employee("Barack", "Obama", 6));
            employees.Add(new Employee("Donald", "Trump", 7));
            employees.Add(new Employee("Joe", "Sakic", 8));
            employees.Add(new Employee("Joe", "Mama", 9));
            employees.Add(new Employee("John", "Cena", 10));

            //Using a foreach loop, create a new list of all employees with the first name "Joe".

            List<Employee> joeList = new List<Employee>();

            foreach(Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            Console.WriteLine(joeList);
            Console.ReadLine();

        }
    }
}



//Perform the same action again, but this time with a lambda expression.
//Using a lambda expression, make a list of all employees with an Id number greater than 5.
//Upload your code to GitHub and paste the link in the space below:

//List<Employees> newList = new List<Employees>();

//List<Employees> employees = new List<Employees>();

//employees.Add(new Employees()
//{
//    Id = 1,
//    FirstName = "Matthew",
//    LastName = "Pope"
//});

//employees.Add(new Employees()
//{
//    Id = 2,
//    FirstName = "John",
//    LastName = "Cena"
//});
//employees.Add(new Employees()
//{
//    Id = 3,
//    FirstName = "Joe",
//    LastName = "Mama"
//});
//employees.Add(new Employees()
//{
//    Id = 4,
//    FirstName = "Joe",
//    LastName = "Sakic"
//});
//employees.Add(new Employees()
//{
//    Id = 5,
//    FirstName = "Jesse",
//    LastName = "Johnson"
//});
//employees.Add(new Employees()
//{
//    Id = 6, 
//    FirstName = "Brett",
//    LastName = "Favre"
//});
//employees.Add(new Employees()
//{
//    Id = 7, 
//    FirstName = "Barack", 
//    LastName = "Obama"
//});
//employees.Add(new Employees()
//{
//    Id = 8,
//    FirstName = "Donald",
//    LastName = "Trump"
//});
//employees.Add(new Employees()
//{
//    Id = 9, 
//    FirstName = "Naruto",
//    LastName = "Uzumaki"
//});
//employees.Add(new Employees()
//{
//    Id = 10, 
//    FirstName = "Sasuke",
//    LastName = "Uchiha"
//});

//Console.WriteLine(employees.);

//foreach (Employees employee in employees)
//{
//    Console.WriteLine(employee.ToString());
//}    


//foreach (string employee in employees)
//{
//    if (!employee.Contains("Joe"))
//    {
//        newList.Add(employee);
//     }

//}


//foreach (var value in employees)
//{
//    var empList = value.firstName;
//    if ()
//}