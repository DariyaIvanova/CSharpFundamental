﻿namespace RemoveNegativesReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList().Where(x => x > 0).ToList();
            numbers.Reverse();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i]<0)
            //    {
            //        numbers.RemoveAt(i);
            //        i--;
            //    }
            //}

            if (numbers.Count==0)
            {
                Console.WriteLine("empty");
                return;
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
