namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();

            string command = commands[0];
            while (command!="print")
            {
                if (command=="add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);
                    numbers.Insert(index, element);
                }
                else if (command=="addMany")
                {
                    int index = int.Parse(commands[1]);
                    List<int> rangeToAdd = commands.Skip(2).Select(int.Parse).ToList();
                    numbers.InsertRange(index, rangeToAdd);
                }
                else if (command=="contains")
                {
                    int element = int.Parse(commands[1]);
                    Console.WriteLine(numbers.IndexOf(element));
                }
                else if (command=="remove")
                {
                    int index = int.Parse(commands[1]);
                    numbers.RemoveAt(index);
                }
                else if (command=="shift")
                {
                    int rotation = int.Parse(commands[1]);

                    for (int i = 0; i < rotation; i++)
                    {
                        int firstElement = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstElement);
                    }
                }
                else if (command=="sumPairs")
                {
                    int currentSum = 0;
                    List<int> sumNumbers = new List<int>();

                    for (int i = 0; i < numbers.Count-1; i+=2)
                    {
                        currentSum = numbers[i] + numbers[i + 1];
                        sumNumbers.Add(currentSum);
                    }
                    if (numbers.Count%2!=0)
                    {
                        sumNumbers.Add(numbers[numbers.Count-1]);
                    }
                    numbers = sumNumbers;
                }
                commands = Console.ReadLine().Split(' ').ToList();
                command = commands[0];
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");

        }
    }
}
