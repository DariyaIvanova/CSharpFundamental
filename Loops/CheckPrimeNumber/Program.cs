namespace CheckPrimeNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;

            while (prime&&(divider<=maxDivider))
            {
                if (num%divider==0)
                {
                    prime = false;
                }
                divider++;
            }
            if (prime&&num>=2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
