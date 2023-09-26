using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Olympic_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            
            var countries = new Dictionary<int, string>()
            {
                {2012, "England"},
                {2000, "Australia"},
                {1994, "Norway"},
                {1998, "Canada"},
                {1976, "Austria"},
                {1968, "France"}
            };

            while (countries.Count > 0)
            {
                int year = countries.Keys.First();
                int randomYear = year + random.Next(countries.Count) * 4;
                if (!countries.ContainsKey(randomYear))
                {
                    randomYear = year + random.Next(countries.Count) * 4;
                    continue;
                }
                Console.WriteLine($"Which country hosted the Summer Olympics year {randomYear}?");

                if (countries[randomYear] == Console.ReadLine())
                {
                    Console.WriteLine("That answer is correct");
                    countries.Remove(randomYear);
                }
                else
                {
                    Console.WriteLine($"Incorrect, it was {countries[randomYear]}");
                }
            }

        }
    }
}
