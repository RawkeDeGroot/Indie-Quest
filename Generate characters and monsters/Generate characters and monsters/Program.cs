using System;

namespace Generate_characters_and_monsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int strengthScore = 0;
            int gelatinousCubeHP = 0;
            int gelatinousCubeArmyHP = 0;

            for (int strengthDice = 0; strengthDice < 3; strengthDice++)
            {
                int d6 = random.Next(1, 7);
                strengthScore += d6;
            }

            for (int cubeHealthDice = 0; cubeHealthDice < 8; cubeHealthDice++)
            {
                int d10 = random.Next(1, 11);
                gelatinousCubeHP += d10 + 5;
            }

            for (int cubeCount = 0; cubeCount < 100; cubeCount++)
            {
                for (int diceCount = 0; diceCount < 8; diceCount++)
                {
                    int d10 = random.Next(1, 11);
                  gelatinousCubeArmyHP += d10 + 5;

                }
            }

            Console.WriteLine($"A character with strength {strengthScore} was created!");
            Console.WriteLine($"A gelatinous cube with {gelatinousCubeHP} HP appears!");
            Console.WriteLine($"Dear gods, an army of 100 cubes descends upon us with a total of {gelatinousCubeArmyHP} HP. We are doomed!");
        }
    } 
}
