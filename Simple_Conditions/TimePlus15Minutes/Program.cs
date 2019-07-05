namespace TimePlus15Minutes
{
    using System;
    using System.Globalization;
 


    class Program
    {
        static void Main(string[] args)
        {
            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());

            //minutes += 15;
            //if (minutes > 59)
            //{
            //    minutes -= 60;
            //    hours += 1;
            //    if (hours>23)
            //    {
            //        hours = 0;
            //    }
            //}
            //if (minutes < 10)
            //{
            //    Console.WriteLine($"{hours}:0{minutes}");
            //}
            //else
            //{
            //    Console.WriteLine($"{hours}:{minutes}");
            //}


            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string hoursToString = hours + ":" + minutes;
            DateTime hoursToDate = DateTime.ParseExact(hoursToString, "H:m", CultureInfo.CurrentCulture  );
            hoursToDate = hoursToDate.AddMinutes(15);
            string hoursToDateAddedMinutes = hoursToDate.ToString("H:mm");
            Console.WriteLine($"{hoursToDateAddedMinutes}");



        }
    }
}
