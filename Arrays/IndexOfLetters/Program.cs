namespace IndexOfLetters
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            string [] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i].ToString().Contains(alphabet[j]))
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
            //a -> 0

            //Console.WriteLine((int)'x');
        }
    }
}
