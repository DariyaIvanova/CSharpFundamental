namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> cardsPlay = new Dictionary<string, string[]>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="JOKER")
                {
                    break;
                }

                string player = command.Split(':', StringSplitOptions.RemoveEmptyEntries)[0];
                command = command.Split(':', StringSplitOptions.RemoveEmptyEntries)[1];

                string[] cards = command.Split(' ', ',')
                    .Where(x => x != string.Empty)
                    .ToArray();


                if (cardsPlay.ContainsKey(player))
                {
                    cardsPlay[player] = cardsPlay[player]
                        .Concat(cards)
                        .Distinct()
                        .ToArray();
                }
                else
                {
                    cardsPlay[player] = cards
                        .Distinct()
                        .ToArray();
                }
            }

            foreach (KeyValuePair<string, string[]> item in cardsPlay)
            {
                Console.WriteLine($"{item.Key}: {GetResult(item.Value)}");
            }
        }

        public static int GetResult(string[] cards)
        {
            int scores = 0;
            foreach (string card in cards)
            {
                scores += GetPower(card) * GetMultiplier(card);

            }
            return scores;
        }

        public static int GetPower(string card)
        {
            switch (card[0])
            {
                case 'J': return 11;
                case 'Q': return 12;
                case 'K': return 13;
                case 'A': return 14;

                default: return int.Parse(card.Substring(0, card.Length - 1));
                    
            }
        }

        public static int GetMultiplier(string card)
        {
            switch (card[card.Length-1])
            {
                case 'S': return 4;
                case 'H': return 3;
                case 'D': return 2;
                case 'C': return 1;

                default: return 0;

            }
        }
    }
}
