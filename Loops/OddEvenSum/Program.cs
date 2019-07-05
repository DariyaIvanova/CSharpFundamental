namespace OddEvenSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            int diff = 0;

            for (int i = 1; i <=n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }
            diff = Math.Abs(evenSum - oddSum);
            if (diff==0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
