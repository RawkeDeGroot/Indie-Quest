using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz_rankings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var score = new SortedList<string, int>();
            bool game = true;

            while (game)
            {

                Console.WriteLine("\nWho won this round?");
                string playerName = Console.ReadLine();

                

                if (score.ContainsKey(playerName))
                {
                    score[playerName]++;
                }
                else
                {
                    score.Add(playerName, 1);
                }

                if (playerName.Length == 0)
                {
                    score.Remove(playerName);
                    game = false;
                }

                var sortedRankings = score.Keys.OrderBy((playerName) => score[playerName]).Reverse().ToList();

                Console.WriteLine($"\nRANKINGS");
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine($"{sortedRankings[i]} {score[sortedRankings[i]]}");
                }
            }
        }
    }
}
