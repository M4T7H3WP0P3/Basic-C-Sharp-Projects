using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    public class Employee
    {
        public int id;
        public string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //public void Display()
        //{
        //    Console.WriteLine($"ID: {id}");
        //    Console.ReadLine();
        //}



        public static bool operator ==(Employee e1, Employee e2)
        {
            if (e1.id == e2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static bool operator !=(Employee e1, Employee e2)
        {
            if (e1.id != e2.id)
            {
                return false;
            }
            else
            {
                return true;
            }    
        }
    }      

}
//public static List<Employee> Employees { get; set; }
//public int ID { get; set; }
//public string firstName { get; set; }
//public string lastName { get; set; }

//public virtual void ListEmployees()
//{
//    foreach (Employee employee in Employees)
//    {
//        Console.WriteLine(employee);

//    }
//}
//public static Program operator+ (Employee employee)
//{
//    employee.Employees.Add(employee);

//}