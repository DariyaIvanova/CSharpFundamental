namespace MaxNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum>maxNumber)
                {
                    maxNumber = currentNum;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
