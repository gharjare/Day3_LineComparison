using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComarisonProblem
{
    public class CompareTo
    {
        public static void MethodCompare()
        {
            int x1 = 8;
            int x2 = 5;
            int y1 = 6;
            int y2 = 7;
            int x3 = 4;
            int y3 = 9;
            int x4 = 5;
            int y4 = 7;

            if(x2 == x4 && y2 == y4)
            {
                Console.WriteLine("The line is equal");
            }else if(x1 >= x3 )
            {
                Console.WriteLine("The first line greater than the other line");
            }
            else
            {
                Console.WriteLine("The line is less than other line");
            }

               
        }
    }
}
