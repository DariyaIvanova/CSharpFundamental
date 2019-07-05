namespace Sequence_2k___1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int currentNum = 1;

            while (currentNum <=n) 
            {
                Console.WriteLine(currentNum);
               // int num = currentNum;
                currentNum = 2 * currentNum + 1;

            }
        }
    }
}
