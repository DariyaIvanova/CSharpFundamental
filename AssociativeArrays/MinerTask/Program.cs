namespace MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();

            string preciousMetal = Console.ReadLine();


            while (preciousMetal!="stop")
            {
                long weigth = long.Parse(Console.ReadLine());
                if (resources.ContainsKey(preciousMetal))
                {
                    resources[preciousMetal] += weigth;
                }
                else
                {
                    resources[preciousMetal] = weigth;
                }

                preciousMetal = Console.ReadLine();
               
            }

            foreach (KeyValuePair<string, long> item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
