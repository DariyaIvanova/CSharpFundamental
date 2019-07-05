using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double areaOfFigure = 0.00;

            if (figure=="square")
            {
                double side = double.Parse(Console.ReadLine());
                areaOfFigure = side * side;
            }
            else if (figure=="rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                areaOfFigure = sideA * sideB;

            }
            else if (figure=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                areaOfFigure = Math.PI * Math.Pow(radius,2);
            }
            else
            {
                double sideTriangle = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                areaOfFigure = sideTriangle * height / 2;
            }

            //Console.WriteLine($"{areaOfFigure:f3}");
            Console.WriteLine(Math.Round(areaOfFigure,3));
        }
    }
}
