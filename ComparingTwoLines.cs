using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComarisonProblem
{
    public class ComparingTwoLines
    {
        public static void ComparingLines()
        {
            int x1 = 4;
            int x2 = 5;
            int y1 = 6;
            int y2 = 7;
            int x3 = 8;
            int y3 = 9;
            int x4 = 5;
            int y4 = 7;

            if(x2 == x4 && y2 == y4)
            {
                Console.WriteLine("The two lines are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }



        }
    }
}
