namespace SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int elToTake = commands[0];
            int elToRemove = commands[1];
            int elToSearchFor = commands[2];

            numbers = numbers.Take(elToTake).ToList();
            numbers = numbers.Skip(elToRemove).ToList();
            if (numbers.Contains(elToSearchFor))
            {
                Console.WriteLine("YES!");
                return;
            }
            Console.WriteLine("NO!");

        }
    }
}
