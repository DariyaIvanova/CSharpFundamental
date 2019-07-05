namespace NumberPyramid
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cuurentNum = 1;
            for (int i = 1; i <= n; i++)
            {             
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(cuurentNum + " ");
                    cuurentNum++;
                    if (cuurentNum > n)
                    {
                        break;
                    }                 
                }
                if (cuurentNum > n)
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
