namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;


            // Collect materials until reach the amount of 250 for some of the key materials
            CollectMaterials(keyMaterials, junkMaterials);

            // Print the legendary item
            Console.WriteLine($"{ObtainLegendary(keyMaterials)} obtained!");

            // Print remaining key mateirals
            PrintMaterals(keyMaterials.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key));

            //Print collected junk materials
            PrintMaterals(junkMaterials.OrderBy(x => x.Key));

        }

        private static void PrintMaterals(IOrderedEnumerable<KeyValuePair<string, int>> materials)
        {
            foreach (KeyValuePair<string, int> material in materials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        private static string ObtainLegendary(Dictionary<string, int> keyMaterials)
        {
            var material = keyMaterials
                .Where(x => x.Value >= 250)
                .First()
                .Key;

            // Remove 250 from the amount to obtain the legendary item
            keyMaterials[material] -= 250;


            switch (material)
            {
                case "shards":
                    return "Shadowmourne";
                case "fragments":
                    return "Valanyr";
                case "motes":
                    return "Dragonwrath";
                default:
                    return "Big ERROR!!! Please call the developer. *** Big ERROR!!! *** Nothing";
            }
        }

        private static void CollectMaterials(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials)
        {
            while (true)
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                for (int i = 0; i < input.Length; i++)
                {
                    var quantity = int.Parse(input[i]);
                    i++;
                    var material = input[i];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material]>=250)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }

            }
        }
    }
}

