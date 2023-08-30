using System;
using System.Collections.Generic;
using System.Threading.Channels;


namespace Boss_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var characters = new List<string>();
            characters.Add("Robert");
            characters.Add("Steve");
            characters.Add("Danny");
            characters.Add("Owen");



            int basiliskHPDiceRoll = 0;
            int daggerDamage = 0;

            for (int i = 0; i < 8; i++)
            {
                int d8 = random.Next(1, 9);
                basiliskHPDiceRoll += d8;
            }

            int basiliskHP = basiliskHPDiceRoll + 16;

            string charactersDescription = string.Join(",", characters);

            Console.WriteLine($"Fighters {charactersDescription} descend into the dungeon.");
            Console.WriteLine($"A basilisk with {basiliskHP} HP appears!");

            while (basiliskHP > 0 && characters.Count > 0)
            {

                foreach (var character in characters)
                {
                    if (basiliskHP > 0)
                    {

                        Console.Write($"{character} hits the basilisk for");

                        for (int i = 0; i < 1; i++)
                        {
                            int d4 = random.Next(1, 5);
                            daggerDamage += d4;
                        }
                        basiliskHP -= daggerDamage;

                        if (basiliskHP < 0)
                        {
                            basiliskHP = 0;
                        }


                        Console.WriteLine($" {daggerDamage} damage. Basilisk has {basiliskHP} HP left.");
                        daggerDamage = 0;


                    }

                }
                var randomCharacter = random.Next(characters.Count);

                if (basiliskHP > 0 && characters.Count > 0)
                {
                    Console.WriteLine($"The Basilisk uses Petrifying Gaze on {characters[randomCharacter]}!");

                    var conSavingThrow = random.Next(1, 21) + 3;
                    Console.Write($"{characters[randomCharacter]} rolls a {conSavingThrow} ");
                    if (conSavingThrow < 12)
                    {
                        Console.WriteLine($"and fails to be saved. {characters[randomCharacter]} is turned into stone.");
                        characters.Remove(characters[randomCharacter]);
                    }
                    else
                    {
                        Console.WriteLine("and is saved from the attack");
                    }
                    conSavingThrow = 0;
                }
            }

            if (basiliskHP == 0)
            {
                Console.WriteLine("The party has defeated the basilisk!");

            }
            if (characters.Count < 1)
            {
                Console.WriteLine("The party has failed and the basilisk continues to turn unsuspecting adventurers to stone.");
            }
        }
    }
}
