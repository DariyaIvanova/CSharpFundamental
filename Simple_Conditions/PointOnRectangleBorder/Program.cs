using System;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());


            bool IsInX = (x>x1) && (x<x2);
            bool IsInY = (y>y1) && (y<y2);

            bool IsInsideArea = IsInX && IsInY;
            bool OnBorder = ((x == x1) && ((y >= y1) && (y <= y2)))
                            || ((x == x2) && ((y >= y1) && (y <= y2)))
                            || ((y == y1) && ((x >= x1) && (x <= x2)))
                            ||((y == y2) && ((x >= x1) && (x <= x2)));
           if (OnBorder)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
