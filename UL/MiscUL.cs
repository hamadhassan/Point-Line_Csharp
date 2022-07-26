using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndLine.UL
{
    internal class MiscUL
    {
        public static int mainMenu()
        {
            Console.WriteLine("1. Make a Line");
            Console.WriteLine("2. Update the begin point");
            Console.WriteLine("3. Update the end point");
            Console.WriteLine("4. Show the begin point");
            Console.WriteLine("5. Show the end point");
            Console.WriteLine("6. Get the length of the line");
            Console.WriteLine("7. Get the gradient of the line");
            Console.WriteLine("8. Find the distance of begin point from zero corrdinates");
            Console.WriteLine("9. Find the distance of end point from zero corrdinates");
            Console.WriteLine("10. Exit");
            Console.Write("Enter option...");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void clearScreen()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
