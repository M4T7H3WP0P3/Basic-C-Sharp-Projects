using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Operations
    {
        public void Operation(out int x, int y)
        {
            x = 2;

            int result = y / x;

            Console.WriteLine("Your number will be divided by " + x);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public void Operation(out int x, out int z, int y)
        {
            x = 5;
            z = 10;

            int result1 = x * y;

            int result2 = y + z;

            Console.WriteLine("You number will be multiplied by " + x);
            Console.WriteLine(result1);

            Console.WriteLine("Your number will be added to " + z);
            Console.WriteLine(result2);
            Console.ReadLine();

        }
    }
}
