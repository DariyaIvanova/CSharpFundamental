namespace Factorial
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;

            do
            {
                factorial *= n;
                n--;
            } while (n>0);
            Console.WriteLine(factorial);
        }
       
    }
}
