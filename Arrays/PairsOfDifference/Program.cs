namespace PairsOfDifference
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    
                    if ((numbers[i]-numbers[j])==diff|| (numbers[j] - numbers[i]) == diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);


        }
    }
}
