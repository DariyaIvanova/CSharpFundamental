namespace SumReversedNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            List<int>SumReversedNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string num = numbers[i];
                string reversedNum = ReverseTheString(num);
                int element = int.Parse(reversedNum);
                SumReversedNumbers.Add(element);
            }

            Console.WriteLine(SumReversedNumbers.Sum());

        }

        public static string ReverseTheString(string number)
        {
            char[] arr = number.ToArray();
            char[] reversedArr = arr.Reverse().ToArray();
            string reversedString = string.Join("", reversedArr);
            return reversedString;
        }
       
    }
}
