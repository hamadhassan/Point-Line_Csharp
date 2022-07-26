using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;

namespace PointAndLine.UL
{
    internal class PointUL
    {
        public static int origRow;
        public static int origCol;
        public static void Write(Point newPoint)
        {
            Console.SetCursorPosition(origRow + newPoint.getY(), origCol + newPoint.getX());
            Console.Write(".");
        }
        public static void WriteLine(Point newPoint)
        {
            Console.SetCursorPosition(origRow + newPoint.getY(), origCol + newPoint.getX());
            for (int x = 0; x < newPoint.getX(); x++)
            {
                for (int y = 0; y < newPoint.getY(); y++)
                {
                    Console.Write(".");
                }
            }
        }
        public static int getInputX()
        {
            int x;
            Console.Write("Enter x axis :");
            x = int.Parse(Console.ReadLine());
            return x;
        }
        public static int getInputY()
        {
            int y;
            Console.Write("Enter y axix :");
            y = int.Parse(Console.ReadLine());
            return y;
        }
        public static Point getPoint()
        {
            int x= getInputX();
            int y = getInputY();
            Point newPoint=new Point(x,y);
            return newPoint;
        }
    }
}
