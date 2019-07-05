namespace PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> population = new Dictionary<string, Dictionary<string, long>>();
            List<string> data = Console.ReadLine().Split('|').ToList();

            

            while (data[0]!="report")
            {
                string city = data[0];
                string country = data[1];
                long populationCount = long.Parse(data[2]);

                if (!population.ContainsKey(country))
                {
                    population[country] = new Dictionary<string, long>();
                }

                population[country][city] = populationCount;


                data = Console.ReadLine().Split('|').ToList();
            }

            foreach (KeyValuePair<string, Dictionary<string,long>> item in population.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");

                foreach (KeyValuePair<string, long> city in item.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
