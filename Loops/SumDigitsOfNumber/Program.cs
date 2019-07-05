namespace SumDigitsOfNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //string num = Console.ReadLine();  //6534
            //int sum = 0;

            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += int.Parse(num[i].ToString());
            //}
            //Console.WriteLine(sum);

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
           

        }
    }
}
