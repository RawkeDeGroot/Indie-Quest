using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Generate_Characters__5th_Edition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var diceThrows = new List<int>();
            var abilityScores = new List<int>();

            for (int abilityScoreIndex = 0; abilityScoreIndex < 6; abilityScoreIndex++)
            {

                for (int diceThrowIndex = 0; diceThrowIndex < 4; diceThrowIndex++)
                {
                    var diceThrow = random.Next(1, 7);
                    diceThrows.Add(diceThrow);
                }
                string diceThrowsDescription = string.Join(",", diceThrows);
                Console.Write($"You roll {diceThrowsDescription}.");
                
                diceThrows.Sort();
                
                int abilityScore = diceThrows[1] + diceThrows[2] + diceThrows[3];
                Console.WriteLine($" The ability score is {abilityScore}");
                abilityScores.Add(abilityScore);
                
                diceThrows.Clear();
            }
            abilityScores.Sort();
            string abilityScoresDescription = string.Join(",", abilityScores);
            Console.WriteLine($"Your available ability scores are: {abilityScoresDescription}");
        }
    }
}