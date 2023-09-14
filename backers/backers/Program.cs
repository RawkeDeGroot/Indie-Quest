using System;
using System.IO;
using System.Linq;

namespace backers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerNamePath = "player-name.txt";
            string backersFile = "backers.txt";
            string[] backersArray = File.ReadAllLines(backersFile);

            if (File.Exists(playerNamePath))
            {
                string playerName = File.ReadAllText(playerNamePath);
                Console.WriteLine($"Welcome back {playerName}, let's continue!");
                if ( backersArray.Contains(playerName)) 
                {
                    Console.WriteLine("You successfully enter Dr. Fred's secret laboratory and are greeted with a warm welcome for backing the game's Kickstarter!");
                }
                else
                {
                    Console.WriteLine("Unfortunately I cannot let you into Dr. Fred's secret laboratory.");
                }
            }
            else
            {
                Console.WriteLine("Welcome to your biggest adventure yet!\n \nWhat is your name, traveler?");
                string name = Console.ReadLine();
                File.WriteAllText(playerNamePath, name);
                Console.WriteLine($"Nice to meet you, {name}");
            }
        }
    }
}
