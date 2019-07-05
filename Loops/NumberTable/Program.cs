namespace NumberTable
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        int currentNum = row + col + 1;

            //        if (currentNum>n)
            //        {
            //            currentNum = 2 * n - currentNum;
            //        }
            //        Console.Write(currentNum + " ");                   
            //    }
            //    Console.WriteLine();
            //}

            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <=n; row++)
            {
                for (int col = row; col <= n; col++)
                {
                    Console.Write($"{col} ");
                }
                if (row!=1)
                {
                    for (int i = n - 1; i > n-row; i--)
                    {
                        Console.Write(i+" ");
                    }
                }
                Console.WriteLine();
            }



        }
    }
}
