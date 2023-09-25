using System;

namespace random_number_monsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int[] levels = new int[100];
            Console.Write($"Number of monsters in levels:");
            for (int level  = 0; level < 100; level++) 
            {
                levels[level] = random.Next(1, 51);
            }
            Array.Sort(levels);
            Console.Write(string.Join(", ", levels));
            Console.WriteLine();
        }
    }
}
