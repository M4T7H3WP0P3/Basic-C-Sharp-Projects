using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    public class Operation
    {
        
        public int Operations(int x)
        {
            return x + 20;
        }

        public decimal Operations(double x, double y = 95.3)
        {
            return (decimal)(y - x);
        }

        public int Operations(string x)
        {
            int convertedVariable = Convert.ToInt32(x);
            return convertedVariable * 34;
        }
    }
}
