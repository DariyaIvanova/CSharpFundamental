namespace MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int longestSeqLength = 1; //maxLength
            //int longestSeqStart = 0; //maxStart
            //int currentSeqLength = 1;//currentLength
            //int currentSeqStart = 0;//currentStart

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > array[i - 1])
            //    {
            //        currentSeqLength++;

            //        if (currentSeqLength > longestSeqLength)
            //        {
            //            longestSeqLength = currentSeqLength;
            //            longestSeqStart = currentSeqStart;
            //        }
            //    }
            //    else
            //    {
            //        currentSeqLength = 1;
            //        currentSeqStart = i;
            //    }
            //}

            //for (int i = longestSeqStart; i < longestSeqStart + longestSeqLength; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxLength = 1;
            int currentLength = 1;
            int maxStart = 0;
            int currentStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>arr[i-1])
                {
                    currentLength++;
                    if (currentLength>maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStart = i;
                }
            }
            for (int i = maxStart; i < maxStart+maxLength; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();


        }
    }
}
