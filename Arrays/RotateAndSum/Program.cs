namespace RotateAndSum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] arrRotate = new int[arr.Length];
            int[] sumArray=new int[arr.Length];



            for (int r = 1; r <=k ; r++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arrRotate[(i + r) % arr.Length]=arr[i];
                    sumArray[(i + r) % arr.Length] += arrRotate[(i + r) % arr.Length];
                  
                }
            }

            
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
