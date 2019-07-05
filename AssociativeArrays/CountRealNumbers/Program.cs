namespace CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Dictionary<double, double> occurences = new Dictionary<double, double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<double> currentOccurence = numbers.Where(x => x == numbers[i]).ToList();
                int occurencesCount = currentOccurence.Count;

                occurences[numbers[i]] = occurencesCount;
            }
            foreach (KeyValuePair<double, double> item in occurences.OrderBy(k=>k.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
