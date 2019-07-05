namespace ExtractMiddleElementsOfArary
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
           
            if (arr.Length%2==0&&arr.Length>1)
            {
                Console.WriteLine("{ " + arr[arr.Length/2-1] +", "+arr[arr.Length/2]+ " }");
            }
            else if(arr.Length%2!=0&&arr.Length!=1)
            {
                Console.WriteLine("{ " + arr[arr.Length / 2 - 1] + ", " + arr[arr.Length / 2] + ", " + arr[arr.Length / 2 + 1] + " }");
            }
            else
            {               
                Console.WriteLine("{ " + arr[0] + " }");
            }

        }
    }
}
