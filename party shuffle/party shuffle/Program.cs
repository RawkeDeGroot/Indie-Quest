using System;
using System.Collections.Generic;

namespace party_shuffle
{
    internal class Program
    {
        static Random random = new Random();
        
        static string partyShuffle(List <string> items) 
        { 
            for (int i = items.Count - 1; i > 0; i--) 
            { 
                int j = random.Next(i + 1);
                object temp = items[i];
                items[i] = items[j];
                items[j] = (string)temp;
            }
            return string.Join(", ", items);
        }
        
        static void Main(string[] args)
        {
            var names = new List<string>() { "Allie", "Ben", "Claire", "Dan", "Eleanor" };
            Console.Write("Signed up participants: ");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine("\nGenerating starting order...\n");
            Console.Write("Starting order: ");
            Console.WriteLine(partyShuffle(names));
        }
    }
}
