using System;
using static System.Formats.Asn1.AsnWriter;

namespace Regenerative_Spell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int warriorHP = random.Next(1, 101);
            Console.WriteLine($"Warrior HP: {warriorHP}\nThe Regenerate spell is cast!");

            while (warriorHP < 50)
            {
                Console.WriteLine($"Warrior HP: {warriorHP + 10}");
                warriorHP += 10;
            }

            Console.WriteLine("The Regenerate Spell is complete!");
        }
    }
}
