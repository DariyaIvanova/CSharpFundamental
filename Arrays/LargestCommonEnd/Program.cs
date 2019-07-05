namespace LargestCommonEnd
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ").ToArray();
            string[] arr2 = Console.ReadLine().Split(" ").ToArray();

            int shorterArray = Math.Min(arr1.Length, arr2.Length);
            int left = 0;
            int right = 0;

            for (int i = 0; i < shorterArray; i++)
            {
                if (arr1[i]==arr2[i])
                {
                    left++;
                }
                else
                {
                    break;
                }
            }
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            for (int i = 0; i < shorterArray; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    right++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Math.Max(left, right));
        }
    }
}
