namespace VariablesDataExpressions
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            //ushort n = ushort.Parse(Console.ReadLine());
            //BigInteger bigPower = BigInteger.Pow(n, n);
            //Console.WriteLine(bigPower);

            uint nWingFlaps = uint.Parse(Console.ReadLine());
            double distanceFor1000WingFlaps = double.Parse(Console.ReadLine());
            uint pEndurance = uint.Parse(Console.ReadLine());
            

            double metersTraveled = nWingFlaps / 1000 * distanceFor1000WingFlaps;
            uint pauseSeconds = nWingFlaps/ pEndurance*5;
            double secondsPassed = nWingFlaps / 100 + pauseSeconds;

            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondsPassed} s.");

        }
    }
}
