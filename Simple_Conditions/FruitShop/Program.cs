namespace FruitShop
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double qty = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (dayOfWeek=="monday"|| dayOfWeek == "tuesday"||dayOfWeek == "wednesday"|| dayOfWeek == "thursday"|| dayOfWeek == "friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = qty * 2.50;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "apple":
                        price = qty * 1.20;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "orange":
                        price = qty * 0.85;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "grapefruit":
                        price = qty * 1.45;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "kiwi":
                        price = qty * 2.70;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "pineapple":
                        price = qty * 5.50;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "grapes":
                        price = qty * 3.85;
                        Console.WriteLine($"{price:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                     
                }
            }
            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday" )
            {
                switch (fruit)
                {
                    case "banana":
                        price = qty * 2.70;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "apple":
                        price = qty * 1.25;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "orange":
                        price = qty * 0.90;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "grapefruit":
                        price = qty * 1.60;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "kiwi":
                        price = qty * 3.00;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "pineapple":
                        price = qty * 5.60;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "grapes":
                        price = qty * 4.20;
                        Console.WriteLine($"{price:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else
            {
                Console.WriteLine("error");
            }


            
        }
    }
}
