namespace UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input!="end")
            {

                List<string> commands = input.Split(' ').ToList();
                string ip = commands[0].Substring(3, commands[0].Length-3);
                string user = commands[2].Substring(5, commands[2].Length - 5);

                if (!data.ContainsKey(user))
                {
                    data[user] = new Dictionary<string, int>();
                }

                if (!data[user].ContainsKey(ip))
                {
                    data[user][ip] = 0;
                }
                data[user][ip]++;

                input = Console.ReadLine();

            }

            foreach (KeyValuePair<string, Dictionary<string, int>> item in data.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: ");
                List<string> output = new List<string>();

                foreach (KeyValuePair<string, int> itemInside in item.Value)
                {

                    output.Add($"{itemInside.Key} => {itemInside.Value}");

                }
                Console.Write(string.Join(", ", output));
                Console.Write(".");
                Console.WriteLine();
            }
        }
    }
}
