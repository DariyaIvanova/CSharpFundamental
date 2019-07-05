namespace EqualSums
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int length = numbers.Length;
            int leftSum = 0;
            int rightSum = 0;
            bool found = false;

            for (int pos = 0; pos < length; pos++) //start searching
            {
                for (int L = 0; L < pos; L++)
                {
                    leftSum += numbers[L];
                }
                //sum LEFT numbers from current possition:

                for (int R = pos + 1; R < length; R++)
                {
                    rightSum += numbers[R];
                }
                //sum RIGHT numbers from current possition:

                if (leftSum == rightSum)
                {
                    Console.WriteLine(pos);
                    found = true;

                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }

            }
            if (!found)
            {
                Console.WriteLine("no");
            }

        }
    }
}
