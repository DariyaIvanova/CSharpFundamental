namespace TrippleSum
{
    using System;
    using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int currentSum = 0;
            int counter = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    currentSum = arr[i] + arr[j];

                    for (int index = 0; index < arr.Length; index++)
                    {
                        if (currentSum==arr[index])
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {currentSum}");
                            counter++;
                        }
                        
                    }                   
                }
            }
            if (counter==0)
            {
                Console.WriteLine("No");
            }
            

        }
    }
}
