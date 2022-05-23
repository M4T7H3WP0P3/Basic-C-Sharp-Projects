using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int counter = 10;
            do
            {
                Console.WriteLine(counter + "\t" + Math.Pow(counter, 2));
                counter--;
            }
            while (counter > 5);

            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
