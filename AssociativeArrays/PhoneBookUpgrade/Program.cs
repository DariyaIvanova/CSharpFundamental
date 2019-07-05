namespace PhoneBookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ').ToList();
            Dictionary <string, string> phoneBook = new Dictionary<string, string>();

            while (data[0]!="END")
            {

                string command = data[0];
                switch (command)
                {
                    case "A":
                        string name = data[1];
                        string phoneNumber = data[2];
                        phoneBook[name] = phoneNumber;
                        break;

                    case "S":
                        name = data[1];
                        if (phoneBook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phoneBook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }


                        break;
                    case "ListAll":
                        foreach (KeyValuePair<string, string> item in phoneBook.OrderBy(x=>x.Key))
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                        break;

                    default:
                        break;
                }
                data = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
