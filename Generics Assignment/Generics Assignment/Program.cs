﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    public class Program
    {
          static void Main(string[] args)
          {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("Matthew");
            employee.Things.Add("John");
            employee.Things.Add("Joe");            
            

            Employee<int> empID = new Employee<int>();
            empID.Things = new List<int>();
            empID.Things.Add(1);
            empID.Things.Add(2);
            empID.Things.Add(3);

            //foreach (T item in Employee.Things)
          }


    }
}
//Perform these actions and create a console app that includes the following:

//Make the Employee class take a generic type parameter.
//Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
//Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.
//Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.
//Create a loop that prints all of the Things to the Console.

//var name = new Employee<string>();
//name.Add("Matthew");
//name.Add("John");
//name.Add("Joe");

//var empId = new Employee<int>();
//empId.Add(1);
//empId.Add(2);
//empId.Add(3);

//foreach