using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison
{
    class LineComparison
    {
        double x1, x2, y1, y2, x3, x4, y3, y4, line1_Length, line2_Length;
        public void LineLength()
        {
            Console.WriteLine("Please Enter x , y Co-ordinates of line 1 :");
            Console.WriteLine("Please Enter values of x1 and y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter values of x2 and y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter x , y Co-ordinates of line 2 :");
            Console.WriteLine("Please Enter values of x3 and y3");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter values of x4 and y4");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());

            line1_Length = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2));
            Console.WriteLine("Length of the line 1 is : " + line1_Length);

            line2_Length = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of the line 2 is : " + line2_Length);

            double diff = line1_Length.CompareTo(line2_Length);
            if(diff < 0)
            {
                Console.WriteLine("Length of Line 1 is less than Line2");
            }
            if (diff > 0)
            {
                Console.WriteLine("Length of Line 1 is greater than Line2");
            }
            if (diff == 0)
            {
                Console.WriteLine("Length of Line 1 equal to Line2");
            }
        }
    }
}
