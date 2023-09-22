using System;
using System.Collections.Generic;

namespace Classes
{
    internal class Program
    {
        static Random random = new Random();
        class Location
        {
            public string Name;
            public string Description;
            public List<Location> Neighbours = new List<Location>();
        }

        static void ConnectLocations(Location a, Location b)
        {
            a.Neighbours.Add(b);
            b.Neighbours.Add(a);
        }

        static void Main(string[] args)
        {
            var locations = new List<Location>();

            var winterfell = new Location
            {
                Name = "Winterfell",
                Description = "The capital of the Kingdom of the North."
            };

            locations.Add(winterfell);

            var pyke = new Location
            {
                Name = "Pyke",
                Description = "The stronghold and seat of House Greyjoy."
            };

            locations.Add(pyke);

            var riverrun = new Location
            {
                Name = "Riverrun",
                Description = "A large castle located in the central-western part of the Riverlands."
            };

            locations.Add(riverrun);

            var theTrident = new Location
            {
                Name = "The Trident",
                Description = "One of the largest and most well-known rivers on the continent of Westeros."
            };

            locations.Add(theTrident);

            var kingsLanding = new Location
            {
                Name = "King's Landing",
                Description = "The capital, and largest city, of the Seven Kingdoms."
            };

            locations.Add(kingsLanding);

            var highgarden = new Location
            {
                Name = "Highgarden",
                Description = "The seat of House Tyrell and the regional capital of the Reach."
            };

            locations.Add(highgarden);

            //Connecting Locations
            ConnectLocations(pyke, winterfell);
            ConnectLocations(pyke, highgarden);
            ConnectLocations(pyke, theTrident);
            ConnectLocations(winterfell, riverrun);
            ConnectLocations(theTrident, highgarden);
            ConnectLocations(theTrident, kingsLanding);
            ConnectLocations(riverrun, kingsLanding);
            ConnectLocations(riverrun, highgarden);
            ConnectLocations(kingsLanding, highgarden);

            Location currentLocation = locations[0];

            while (true)
            {
                Console.WriteLine($"Welcome to {currentLocation.Name}, {currentLocation.Description}");
                Console.WriteLine();
                Console.WriteLine($"Possible Destinations are:");
                for (int i = 0; i < currentLocation.Neighbours.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {currentLocation.Neighbours[i].Name}");
                }

                Console.WriteLine();
                Console.WriteLine("Where do you want to travel?");

                string chosenRoute = Console.ReadLine();
                int route = Convert.ToInt32(chosenRoute);
                currentLocation = currentLocation.Neighbours[route - 1];
                Console.Clear();
            }
        }
    }
}