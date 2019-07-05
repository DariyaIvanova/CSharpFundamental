namespace BonusPoints
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;

            if (initialPoints<=100)
            {
                bonusPoints += 5;
            }
            else if ((initialPoints>100)&&(initialPoints<=1000))
            {
                bonusPoints = initialPoints * 20 / 100d;
            }
            else
            {
                bonusPoints= initialPoints * 10 / 100d;
            }

            if (initialPoints%2==0)
            {
                bonusPoints += 1;
            }
            else
            {
                if (initialPoints%5==0)
                {
                    bonusPoints += 2;
                }
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(initialPoints+bonusPoints);
        }
    }
}
