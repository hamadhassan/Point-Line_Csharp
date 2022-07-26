using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndLine.BL
{
    internal class Line
    {
        public static Point begin;
        public static Point end;
        public Point setBeginPoint(Point beginPoint)
        {
            begin = beginPoint;
            return begin;
        }
        public  Point setEndPoint(Point endPoint)
        {
            end = endPoint;
            return endPoint;
        }
        public  double getLength()
        {
            double distance;
            distance=Math.Sqrt((Math.Pow(begin.getX() - end.getX(), 2) + Math.Pow(begin.getY() - end.getY(), 2)));
            return distance;
        }
        public  double getGradient()
        {
            double gradient;
            gradient=((end.getY() - begin.getY()) /(end.getX() - begin.getX()));
            return gradient;
        }
        public  double getDistanceFromBegin()
        {
            double distance ;
            distance = Math.Sqrt((Math.Pow(begin.getX() - 0, 2) + Math.Pow(begin.getY() - 0, 2)));
            return distance;
        }
        public  double getDistanceFromEnd()
        {
            double distance ;
            distance = Math.Sqrt((Math.Pow(end.getX() - 0, 2) + Math.Pow(end.getY() - 0, 2)));
            return distance;
        }
    }
}
