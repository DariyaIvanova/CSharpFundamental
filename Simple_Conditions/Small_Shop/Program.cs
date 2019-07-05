namespace Small_Shop
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double result = 0.0;

            if (city=="Sofia")
            {
                if (product=="coffee")
                {
                     result = 0.50 * qty;

                }
                else if (product=="water")
                {
                     result = 0.80 * qty;

                }
                else if (product == "beer")
                {
                     result = 1.20 * qty;

                }
                else if (product == "sweets")
                {
                     result = 1.45 * qty;

                }
                else
                {
                     result = 1.60 * qty;

                }
            }
            else if (city=="Plovdiv")
            {
                if (product == "coffee")
                {
                     result = 0.40 * qty;

                }
                else if (product == "water")
                {
                     result = 0.70 * qty;

                }
                else if (product == "beer")
                {
                     result = 1.15 * qty;

                }
                else if (product == "sweets")
                {
                     result = 1.30 * qty;

                }
                else
                {
                     result = 1.50 * qty;

                }
            }
            else
            {
                if (product == "coffee")
                {
                     result = 0.45 * qty;

                }
                else if (product == "water")
                {
                     result = 0.70 * qty;

                }
                else if (product == "beer")
                {
                     result = 1.10 * qty;

                }
                else if (product == "sweets")
                {
                     result = 1.35 * qty;
                }
                else
                {
                     result = 1.55 * qty;

                }
            }
            Console.WriteLine(result);
        }
    }
}
