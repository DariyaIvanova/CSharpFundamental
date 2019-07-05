namespace TradeComissions
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0.0;

            if (sales>=0 && sales<=500)
            {
                switch (city)
                {
                    case "sofia":
                        commission = sales * 5 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    case "varna":
                        commission = sales * 4.5 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    case "plovdiv":
                        commission = sales * 5.5 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales >500 && sales <= 1000)
            {
                switch (city)
                {
                    case "sofia":
                        commission = sales * 7 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    case "varna":
                        commission = sales * 7.5 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    case "plovdiv":
                        commission = sales * 8 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales >1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "sofia":
                        commission = sales * 8 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    case "varna":
                        commission = sales * 10 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    case "plovdiv":
                        commission = sales * 12 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales>10000)
            {
                switch (city)
                {
                    case "sofia":
                        commission = sales * 12 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    case "varna":
                        commission = sales * 13 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
                    case "plovdiv":
                        commission = sales * 14.5 / 100d;
                        Console.WriteLine($"{commission:f2}"); break;
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
