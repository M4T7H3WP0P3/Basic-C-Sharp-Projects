using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string dateString = DateTime.Today.ToShortDateString();
            string timeString = DateTime.Now.ToString("hh:mm tt");

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();

            string str = "Hello " + userName + ". Today is " + dateString + " and it is " + timeString + "." ;
            Console.WriteLine(str);
                        
            string welcome = userName.ToUpper() + ", How are you today?";
            
            Console.WriteLine(welcome);

            StringBuilder sb = new StringBuilder(userName);

            sb.Append(" I hope");
            sb.Append(" you have a ");
            sb.Append("great day!");

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
        
    }
}
