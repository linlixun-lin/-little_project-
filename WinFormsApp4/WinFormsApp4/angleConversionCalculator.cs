using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class angleConversionCalculator
    {
        public static double rad2dfm(double rad)//弧度转度分秒
        {
            double agl = Math.Abs(rad) * 180 / Math.PI;
            double dfm = rad / Math.Abs(rad);
            double d = Math.Floor(agl);
            double f = Math.Floor((agl - d) * 60);
            double m = ((agl - d) - f / 60) * 3600;
            dfm = dfm * (d + f / 100 + m / 10000);
            return dfm;
        }
        public static double dfm2rad(double dfm)//度分秒转弧度
        {
            double rad = dfm / Math.Abs(dfm);
            double dfm2 = Math.Abs(dfm);
            double d = Math.Floor(dfm2);
            double f = Math.Floor((dfm2 - d) * 100);
            double m = ((dfm2 - d) - f / 100) * 10000;
            double temp = rad*(d + f / 60 + m / 3600);
            rad = temp / 180 * Math.PI;
            return rad;
        }
        public static double ang2dfm(double ang)//10进制度转度分秒
        {
            double dfm = ang / Math.Abs(ang);
            double d = Math.Floor(ang);
            double f = Math.Floor((ang - d) * 60);
            double m = ((ang - d) - f / 60) * 3600;
            dfm = dfm * (d + f / 100 + m / 10000);
            return dfm;
        }
        public static double dfm2ang(double dfm)//度分秒转10进制度
        {
            double ang = dfm / Math.Abs(dfm);
            double dfm2 = Math.Abs(dfm);
            double d = Math.Floor(dfm2);
            double f = Math.Floor((dfm2 - d) * 100);
            double m = ((dfm2 - d) - f / 100) * 10000;
            ang = ang * (d + f / 60 + m / 3600);
            return ang;
        }
        public static double rad2ang(double rad)//弧度转10进制度
        {
            double ang = Math.Abs(rad) * 180 / Math.PI;
            return ang;
        }
        public static double ang2rad(double ang)//10进制度转弧度
        {
            double rad = ang * Math.PI / 180;
            return rad;
        }
    }
}
