using System;
using System.IO;

namespace Remember_player_name
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string playerNamePath = "player-name.txt";

            if (File.Exists(playerNamePath))
            {
                string name = File.ReadAllText(playerNamePath);
                Console.WriteLine($"Welcome back, {name}, let's continue!");
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
