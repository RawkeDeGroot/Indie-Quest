using System;

namespace Roll_until_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int diceThrow;
            int diceResult = 0;
            do
            {
                diceThrow = random.Next(1, 7);
                Console.WriteLine($"You rolled: {diceThrow}");

              diceResult += diceThrow;

            }
            while (diceThrow < 6);
            Console.WriteLine($"Total score: {diceResult}");
        }
    }
}
