using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class help
    {
        public static double Distance(point p1, point p2)
        {
            double a = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            return a;
        }
        public static double Angle(double a, double b, double c)
        {
            double x = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
            return x;

        }
        
           
    }
}
