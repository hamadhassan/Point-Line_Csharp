using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
using PointAndLine.UL;

namespace PointAndLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                int op = MiscUL.mainMenu();
                if (op == 1)
                {
                    Line draw=new Line();
                    Point begin = LineUL.getBeginPoint();
                    Point end = LineUL.getEndPoint();
                    Console.Clear();
                    PointUL.origRow = Console.CursorTop;
                    PointUL.origCol = Console.CursorLeft;
                    PointUL.Write(draw.setBeginPoint(begin));
                    PointUL.WriteLine(draw.setEndPoint(end));
                    Console.ReadLine();
                }
                else if (op == 2)
                {
                    Point begin = LineUL.getBeginPoint();
                    Line updateBegin = new Line();
                    updateBegin.setBeginPoint(begin);
                }
                else if (op == 3)
                {
                    Point end = LineUL.getEndPoint();
                    Line updateEnd=new Line();
                    updateEnd.setEndPoint(end);
                }
                else if(op == 4)
                {
                    Console.Clear();
                    PointUL.origRow = Console.CursorTop;
                    PointUL.origCol = Console.CursorLeft;
                    PointUL.Write(Line.begin);
                }
                else if (op == 5)
                {
                    Console.Clear();
                    PointUL.origRow = Console.CursorTop;
                    PointUL.origCol = Console.CursorLeft;
                    PointUL.Write(Line.end);
                }
                else if (op == 6)
                {
                    Line length=new Line();
                    double distance=length.getLength();
                    LineUL.viewDistance(distance);
                }
                else if (op == 7)
                {
                    Line grad = new Line();
                    double gradient= grad.getGradient();
                    LineUL.viewGradient(gradient);
                }
                else if (op == 8)
                {
                    Line dis = new Line();
                    double distance = dis.getDistanceFromBegin();
                    LineUL.viewDistanceFromBegin(distance);
                }
                else if (op == 9)
                {
                    Line dis = new Line();
                    double distance =dis.getDistanceFromEnd();
                    LineUL.viewDistanceFromEnd(distance);
                }
                else if (op == 10)
                {
                    break;
                }
                MiscUL.clearScreen();
            }
            Console.ReadLine();
        }
    }
}
