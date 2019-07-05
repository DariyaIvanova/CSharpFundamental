using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            double inputInMeters = 0.0;
            double result = 0.0;

            if (inputMetric=="m")
            {
                inputInMeters = 1;
            }
            else if (inputMetric=="mm")
            {
                inputInMeters = 1/1000d;
            }
            else if (inputMetric == "cm")
            {
                inputInMeters = 1/100d;
            }
            else if (inputMetric == "mi")
            {
                inputInMeters = 1/0.000621371192d;
            }
            else if (inputMetric == "in")
            {
                inputInMeters = 1 / 39.3700787d;
            }
            else if (inputMetric == "km")
            {
                inputInMeters = 1 / 0.001d;
            }
            else if (inputMetric == "ft")
            {
                inputInMeters = 1 / 3.2808399d;
            }
            else
            {
                inputInMeters = 1 / 1.0936133d;
            }


            if (outputMetric == "m")
            {
                result = inputInMeters * number * 1;
            }
            else if (outputMetric == "mm")
            {
                result = inputInMeters * number * 1000;
            }
            else if (outputMetric == "cm")
            {
                result = inputInMeters * number * 100;
            }
            else if (outputMetric == "mi")
            {
                result = inputInMeters * number * 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                result = inputInMeters * number * 39.3700787;
            }
            else if (outputMetric == "km")
            {
                result = inputInMeters * number * 0.001;
            }
            else if (outputMetric == "ft")
            {
                result = inputInMeters * number * 3.2808399;
            }
            else
            {
                result = inputInMeters * number * 1.0936133;
            }

            Console.WriteLine($"{result:f8}");
        }
    }
}
