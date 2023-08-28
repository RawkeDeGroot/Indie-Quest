using System;
using System.Threading.Channels;

namespace Tankgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int tankDistance = random.Next(40, 71);
            int endDistance = 77 - tankDistance;
            bool victory = false;

            Console.WriteLine("DANGER! A tank is approaching our position. Your artillery unit is our only hope!\n");
            Console.WriteLine("What is your name, commander?");
            Console.WriteLine("Enter name:");
            string userName = Console.ReadLine();
            Console.WriteLine("\nHere is a map of the battlefield:\n");


            string battlefield = "_/";
            string battlefieldLeft = "";


            for (int i = 0; i < tankDistance; i++)
            {
                battlefield += "_";

            }

            for (int i = 0; i < endDistance; i++)
            {

                battlefieldLeft += "_";
            }
            Console.WriteLine($"{battlefield}T{battlefieldLeft}");
            int shellsLeft = 5;
            if (victory == false)
                while (victory == false && shellsLeft > 0) 
                {
                    
                    Console.WriteLine($"Aim your shot, {userName}!");
                    Console.WriteLine("Enter distance:");
                    int aimDistance = Convert.ToInt32(Console.ReadLine());
                    string aimDistanceGraphic = "";

                    for (int i = 1; i <= aimDistance; i++)
                    {

                        aimDistanceGraphic += " ";

                    }
                    Console.WriteLine($"  {aimDistanceGraphic}*");

                    if (aimDistance == tankDistance)
                    {
                        Console.WriteLine("BOOM! Your aim is legendary and the tank is destroyed!");
                        victory = true;
                        Console.WriteLine( "Press any key to continue...");
                    }
                    if (aimDistance < tankDistance)
                    {
                        Console.WriteLine("Oh no, your shot was too short.");
                        shellsLeft = shellsLeft - 1;
                        Console.WriteLine($"You have {shellsLeft} shells left!");
                    }
                    if (aimDistance > tankDistance)
                    {
                        Console.WriteLine("Alas, the shell flies past the tank.");
                        shellsLeft = shellsLeft - 1;
                        Console.WriteLine($"You have {shellsLeft} shells left!");
                    }
                    
                }
            
            
            if (victory == false)
            {
                Console.WriteLine("Defeat! The tank destroys your artillery position.");

                    }
        }
    }
}