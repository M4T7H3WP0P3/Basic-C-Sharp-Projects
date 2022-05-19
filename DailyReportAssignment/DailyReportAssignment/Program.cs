using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you in?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int currentPage = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer true or false");
            bool helpNeeded = Convert.ToBoolean(Console.ReadLine());
            

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specifics");
            string courseFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string dailyHours = Console.ReadLine();
            int hoursLogged = Convert.ToInt32(dailyHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        }
    }
}
