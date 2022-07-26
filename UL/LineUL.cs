using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;

namespace PointAndLine.UL
{
    internal class LineUL
    {
        public static Point getBeginPoint()
        {
            Point begin = PointUL.getPoint();
            return begin;
        }
        public static Point getEndPoint()
        {
            Point end = PointUL.getPoint();
            return end;
        }
        public static void viewDistance(double distance)
        {
            Console.WriteLine("Distance is "+distance);
        }
        public static void viewGradient(double gradient)
        {
            Console.WriteLine("Gradient is " + gradient);
        }
        public static void viewDistanceFromBegin(double distance)
        {
            Console.WriteLine("Distance from begin is " + distance);
        }
        public static void viewDistanceFromEnd(double distance)
        {
            Console.WriteLine("Distance from end is " + distance);
        }
    }
}
