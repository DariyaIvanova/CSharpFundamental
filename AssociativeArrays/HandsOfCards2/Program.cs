namespace HandsOfCards2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(':').ToList();

            Dictionary<char, int> powers = new Dictionary<char, int>()
            {
                {'S', 4},
                {'H', 3},
                {'D', 2},
                {'C', 1}
            };

            Dictionary<char, int> specialCards = new Dictionary<char, int>()
            {
                {'J', 11},
                {'Q', 12},
                {'K', 13},
                {'A', 14}
            };

            Dictionary<string, HashSet<string>> players = new Dictionary<string, HashSet<string>>();
            Dictionary<string, int> result = new Dictionary<string, int>();


            while (data[0]!="JOKER")
            {

                string name = data[0];
                //HashSet<string> cards = data[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToHashSet();

                List<string> cardsList = data[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                HashSet<string> cards = new HashSet<string>(cardsList);

                if (!players.ContainsKey(name))
                {
                    players[name] = new HashSet<string>();
                }

                    players[name].UnionWith(cards);



                data = Console.ReadLine().Split(':').ToList();
            }

            foreach (KeyValuePair<string, HashSet<string>> item in players)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value)}");
            }

            foreach (KeyValuePair<string, HashSet<string>> player in players)
            {
                int sum = 0;
                

                foreach (string item in player.Value)
                {
                    if (item.Length==2)
                    {

                        if (item[0]>='2' && item[0]<='9')
                        {
                            sum +=int.Parse(item[0].ToString()) * powers[item[1]];
                        }
                        else
                        {
                            sum += specialCards[item[0]] * powers[item[1]];
                        }
                      
                    }
                    else
                    {
                        
                        sum += 10 * powers[item[2]];
                    }
                }
                result[player.Key] = sum;
            }


            foreach (KeyValuePair<string, int> item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }



        }
    }
}
