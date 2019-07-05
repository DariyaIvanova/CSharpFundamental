namespace EqualPairs
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOldPair = 0;
            int sumNewPair = 0;
            int maxDiff = 1;
            int counter = 0;

            for (int i = 1; i <=n; i++)
            {
                int f = int.Parse(Console.ReadLine());
                int s = int.Parse(Console.ReadLine());

                sumNewPair = f + s;

                if (sumNewPair==sumOldPair)
                {
                    counter++;
                }

                if (maxDiff< Math.Abs(sumNewPair-sumOldPair)&&i>1)
                {
                    maxDiff = Math.Abs(sumNewPair-sumOldPair);
                }
                if (sumNewPair!=sumOldPair)
                {
                    sumOldPair = sumNewPair;
                }
            }
            if (counter==n-1)
            {
                Console.WriteLine($"Yes, value={sumNewPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
