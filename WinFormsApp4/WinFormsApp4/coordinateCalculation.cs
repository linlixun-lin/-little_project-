using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public struct point 
    {
        public double x;
        public double y;
    }

    internal class coordinateCalculation
    {
        public static point forwardCal(point p1, double distance, double dfm)//给定起点坐标，以及距离和方位角计算点位坐标
        {
            point p2 = new point();
            double rad = angleConversionCalculator.dfm2rad(dfm);
            p2.x = p1.x + distance * Math.Cos(rad);
            p2.y = p1.y + distance * Math.Sin(rad);
            return p2;
        }
        public static double Distance(point p1, point p2)//给定两点坐标计算两点间距离
        {
            double distance;
            distance = Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
            return distance;
        }
        public static double ang(point p1, point p2)//给定两点坐标计算两点方位角
        {
            double dx = p2.x - p1.x;
            double dy = p2.y - p1.y;
            double result;

            if (dx == 0 && dy == 0)
            {
                throw new InvalidOperationException("两点重合，无法计算方位角");
            }


            if (dy > 0) 
            {
                if (dx > 0)
                {
                    return result = (Math.Atan(dy / dx));
                }
                else if (dx < 0)
                {
                    return result = (Math.Atan(dy / dx) + Math.PI);
                }
                else
                {
                    return result = (Math.PI / 2);
                }
            }
            else if (dy < 0) 
            {
                if (dx < 0)
                {
                    return result = (Math.Atan(dy / dx) + Math.PI);
                }
                else if (dx > 0)
                {
                    return result = (Math.Atan(dy / dx) + 2 * Math.PI);
                }
                else
                {
                    return result = (3 * Math.PI / 2);
                }
            }
            else 
            {
                if (dx > 0)
                {
                    return result = (0);
                }
                else if (dx < 0)
                {
                    return result = (Math.PI);
                }
                else
                {
                    throw new InvalidOperationException("无效坐标变化");
                }
            }
        }

    }
}
