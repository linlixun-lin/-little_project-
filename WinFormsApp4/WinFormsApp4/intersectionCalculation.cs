using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    internal class intersectionCalculation
    {
        public static point angAhead(point x, point y, double angX, double angY)//角度前方交汇
        {
            point a = new point();
            double radX = angleConversionCalculator.dfm2rad(angX);
            double radY = angleConversionCalculator.dfm2rad(angY);
            a.x = (x.x / Math.Tan(radY) + y.x / Math.Tan(radX) - x.y + y.y) / (1 / Math.Tan(radY) + 1 / Math.Tan(radX));
            a.y = (x.y / Math.Tan(radY) + y.y / Math.Tan(radX) + x.x - y.x) / (1 / Math.Tan(radY) + 1 / Math.Tan(radX));
            return a;
        }
        public static point angAfter(point a, point b, point c, double x, double y, double z)//角度后方交汇
        {
            point p = new point();
           
            x = angleConversionCalculator.dfm2rad(x);
            y = angleConversionCalculator.dfm2rad(y);
            z = angleConversionCalculator.dfm2rad(z);
            double disBC = coordinateCalculation.Distance(b, c);
            double disAB= coordinateCalculation.Distance(b, a);
            double disAC= coordinateCalculation.Distance(c, a);
            double A = help.Angle(disAB, disAC, disBC);
            double B=help.Angle(disAB, disBC, disAC);
            double C=help.Angle(disAC, disBC, disAB);

            double pA = (Math.Sin(x) * Math.Sin(A)) /(Math.Cos(A) * Math.Sin(x) - Math.Cos(x) * Math.Sin(A));
            double pB = (Math.Sin(y) * Math.Sin(B)) / (Math.Cos(B) * Math.Sin(y) - Math.Cos(y) * Math.Sin(B));
            double pC = (Math.Sin(z) * Math.Sin(C)) / (Math.Cos(C) * Math.Sin(z) - Math.Cos(z) * Math.Sin(C));

            p.x = (pA * a.x + pB * b.x + pC * c.x) / (pA + pB + pC);
            p.y = (pA * a.y + pB * b.y + pC * c.y) / (pA + pB + pC);
            return p;
        }
        public static point angDis(point a, point b, double disPB, double disPA)//距离交汇
        {
            double AB = coordinateCalculation.ang(a, b);
            double BA = coordinateCalculation.ang(b, a);
            double BAP = help.Angle(coordinateCalculation.Distance(a, b), disPA, disPB);
            double ABP = help.Angle(coordinateCalculation.Distance(a, b), disPB, disPA);
            double AP = AB - BAP;
            double BP = BA + ABP;

            point p = new point();
            p.x = a.x + disPA * Math.Cos(AP);
            p.y = a.y + disPA * Math.Sin(AP);
            point p2 = new point();
            p2.x = b.x + disPB * Math.Cos(BP);
            p2.y = b.y + disPB * Math.Sin(BP);
            p.x = (p.x + p2.x) / 2;
            p.y = (p.y + p2.y) / 2;
            return p;
        }
    }
}
