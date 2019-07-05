namespace OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> occurrences = new Dictionary<string, int>();
            List<string> toPrint = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                List<string> currentOccurrence = input.Where(x => x == input[i]).ToList();
                int countOccurrence = currentOccurrence.Count;
                if (countOccurrence%2!=0)
                {
                    occurrences[input[i]] = countOccurrence;
                }
                
            }
            foreach (KeyValuePair<string, int> item in occurrences)
            {               
                toPrint.Add(item.Key);                
            }
            Console.WriteLine(string.Join(", ", toPrint));
        }
    }
}
