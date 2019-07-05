namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();


            while (data[0]!="END")
            {
                string command = data[0];
                string name = data[1];

                switch (command)
                {
                    case "A":
                        
                        string phone = data[2];
                        phoneBook[name] = phone;

                        break;

                    case "S":

                        if (phoneBook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phoneBook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                        break;


                    default:
                        break;
                }


                data= Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
