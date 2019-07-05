using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int colomns = int.Parse(Console.ReadLine());
            double incomes = 0.0;

            int allSeats = rows * colomns;
            switch (projection)
            {
                case "premiere":
                    incomes = allSeats * 12.00d;
                    Console.WriteLine($"{incomes:f2}");
                    break;
                case "normal":
                    incomes = allSeats * 7.50d;
                    Console.WriteLine($"{incomes:f2}");
                    break;
                case "discount":
                    incomes = allSeats * 5.00d;
                    Console.WriteLine($"{incomes:f2}");
                    break;
                default:
                    Console.WriteLine("error"); break;
            }
        }
    }
}
