using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perform these actions and create a console app that includes the following:

            //Create a const variable.

            const string teamName = "Tigers";

            //Create a variable using the keyword "var.”
            Console.WriteLine("Please choose your position: C, LW, RW, D, G");

            var position = Console.ReadLine();

            Player player = new Player("Matthew", 88);

            Console.WriteLine($"{player.name} plays {position} for the {teamName}, and wears jersey number {player.number}");
            Console.ReadLine();


            
        }
    }

    class Player
    {
        public string name;
        public int number;

        public Player (string name = "", int number = 0)
        {
            this.name = name;
            this.number = number;
        }
    }
}





//Chain two constructors together.