namespace SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i])!=Math.Truncate(Math.Sqrt(numbers[i])))
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
