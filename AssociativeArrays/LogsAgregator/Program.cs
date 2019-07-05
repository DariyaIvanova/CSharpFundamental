namespace LogsAgregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                List<string> data = input.Split(' ').ToList();
                string ip = data[0];
                string name = data[1];
                int duration = int.Parse(data[2]);

                if (!logs.ContainsKey(name))
                {
                    //logs[name] = new Dictionary<string, int>();
                    logs.Add(name, new Dictionary<string, int>());
                }
                if (!logs[name].ContainsKey(ip))
                {
                    //logs[name][ip] = duration;
                    logs[name].Add(ip, duration);
                }
                else
                {
                    logs[name][ip] += duration;
                }

                //alex: 62 [10.10.17.33, 212.50.118.81]
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> item in logs.OrderBy(x=>x.Key))
            {
                
                int totalDurationOfUser = item.Value.Values.Sum();
                Console.Write($"{item.Key}: {totalDurationOfUser} ");

                List<string> listIps = new List<string>();
                foreach (KeyValuePair<string, int> itemInner in item.Value.OrderBy(x=>x.Key))
                {
                    listIps.Add(itemInner.Key);
                }
                listIps = listIps.Distinct().ToList();

                Console.WriteLine($"[{string.Join(", ",listIps)}]");
            }
            Console.WriteLine();



            
        }
    }
}
