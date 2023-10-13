using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;


namespace Dice_roll_method
{
    internal class Program
    {
        static int DiceRoll(int numberOfRolls, int diceSides, int fixedBonus = 0)
        {
            var random = new Random();
            int sum = 0;

            for (int i = 0; i < numberOfRolls; i++)
            {
                var roll = random.Next(1, diceSides + 1);
                sum += roll;
            }
            sum += fixedBonus;
            return sum;
        }


        static void SimulateCombat(List<string> characterNames, string monsterName, int monsterHP, int savingThrowDC)
        {
            var random = new Random();

            int weaponDamage = 0;

            string charactersDescription = string.Join(", ", characterNames);


            Console.WriteLine($"Watch out! A {monsterName} with {monsterHP} HP appears!");

            while (monsterHP > 0 && characterNames.Count > 0)
            {

                foreach (var character in characterNames)
                {
                    if (monsterHP > 0)
                    {

                        Console.Write($"{character} hits the {monsterName} for");

                        weaponDamage = DiceRoll(2, 6);

                        monsterHP -= weaponDamage;

                        if (monsterHP < 0)
                        {
                            monsterHP = 0;
                        }


                        Console.WriteLine($" {weaponDamage} damage. {monsterName} has {monsterHP} HP left.");
                        weaponDamage = 0;


                    }

                }
                var randomCharacter = random.Next(characterNames.Count);

                if (monsterHP > 0 && characterNames.Count > 0)
                {
                    Console.WriteLine($"The {monsterName} attacks {characterNames[randomCharacter]}!");

                    var conSavingThrow = DiceRoll(1, 20, 3);
                    Console.Write($"{characterNames[randomCharacter]} rolls a {conSavingThrow} ");
                    if (conSavingThrow < savingThrowDC)
                    {
                        Console.WriteLine($"and fails to be saved. {characterNames[randomCharacter]} is killed.");
                        characterNames.Remove(characterNames[randomCharacter]);
                    }
                    else
                    {
                        Console.WriteLine("and is saved from the attack");
                    }
                    
                }
            }

            if (monsterHP == 0)
            {
                Console.WriteLine($"The {monsterName} collapses and the heroes celebrate their victory!");

            }
            if (characterNames.Count < 1)
            {
                Console.WriteLine($"The party has failed and the {monsterName} continues to rampage through the lands.");
            }
        }

        static void Main(string[] args)
        {
            var characterNames = new List<string>();
            characterNames.Add("Steve");
            characterNames.Add("Niko");
            characterNames.Add("Gary");
            characterNames.Add("John");

            string charactersDescription = string.Join(", ", characterNames);

            Console.WriteLine($"Fighters {charactersDescription} descend into the dungeon.");

            SimulateCombat(characterNames, "Orc", DiceRoll(2, 8, 6), 10);

            if (characterNames.Count > 0)
            {
                SimulateCombat(characterNames, "Azer", DiceRoll(6, 8, 12), 18);

                if (characterNames.Count > 0)
                {
                    SimulateCombat(characterNames, "Troll", DiceRoll(8, 10, 40), 16);

                    if (characterNames.Count > 0)
                    {
                        Console.WriteLine($"After three grueling battles, the heroes {string.Join(", ", characterNames)} return from the dungeons to live another day.");
                    }
                }
            }
        }
    }
}
