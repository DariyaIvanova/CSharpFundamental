namespace ReverseAnArrayOfIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(nums);
            Console.WriteLine(string.Join(" ", nums));
           
        }
    }
}
