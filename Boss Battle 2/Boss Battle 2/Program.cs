using System;
using System.Collections.Generic;
using System.Threading.Channels;


namespace Boss_Battle_2
{
    internal class Program
    {
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

                        for (int i = 0; i < 2; i++)
                        {
                            int d6 = random.Next(1, 7);
                            weaponDamage += d6;
                        }
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

                    var conSavingThrow = random.Next(1, 21) + 3;
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
                    conSavingThrow = 0;
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

            SimulateCombat(characterNames, "Orc", 15, 10);

            if (characterNames.Count > 0)
            {
                SimulateCombat(characterNames, "Azer", 39, 18);

                if (characterNames.Count > 0)
                {
                    SimulateCombat(characterNames, "Troll", 84, 16);

                    if (characterNames.Count > 0)
                    {
                        Console.WriteLine($"After three grueling battles, the heroes {string.Join(", ", characterNames)} return from the dungeons to live another day.");
                    }
                }
            }
        }
    }
}
