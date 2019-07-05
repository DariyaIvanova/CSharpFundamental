﻿namespace LeftRightSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int diff = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                leftSum += currentNum;
            }

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                rightSum += currentNum;
            }

            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                diff = Math.Abs(leftSum-rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
