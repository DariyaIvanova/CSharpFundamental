namespace MostFrequentNumber
{
    using System;
    using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            ushort[] numbers = Console.ReadLine().Split(" ").Select(ushort.Parse).ToArray();
            int currentCount = 0;
            int maxCount = 0;
            int maxIndex = 0;


            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                for (int j = numbers.Length - 1; j >= 0; j--)
                {
                    if (numbers[i]==numbers[j])
                    {
                        currentCount++;
                    }
                    if (currentCount>=maxCount)
                    {
                        maxCount = currentCount;
                        maxIndex = i;
                    }
                }
                currentCount = 0;
            }
            Console.WriteLine(numbers[maxIndex]);
           
        }
    }
}
