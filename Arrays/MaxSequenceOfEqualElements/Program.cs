namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int start = 0;
            int max = 0;
            int counter = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]==arr[i+1])
                {
                    counter++;
                    if (counter>max)
                    {
                        start = i - counter;
                        max = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            for (int i = start+1; i <=start+max+1 ; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            //0 1 2 3 4 5 6 7 8 9
            //2 1 1 2 3 3 2 2 2 1
        }
    }
}
