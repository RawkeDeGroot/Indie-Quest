using System;
using System.Collections.Generic;
using System.Linq;

namespace Serial_Comma
{
    internal class Program
    {

        static string JoinWithAnd(List<string> items, bool useSerialComma = true)
        {
            var count = items.Count;
            if (count == 0)
            {
                return "-";
            }
            else if (count == 1)
            {
                return items[0];
            }
            else if (count == 2)
            {
                return string.Join(" and ", items);
            }
            else
            {
                var heroesCopy = new List<string>(items);


                if (useSerialComma)
                {
                    heroesCopy[^1] = $"and {heroesCopy[^1]}";

                }
                else
                {
                    heroesCopy[^2] = $"{heroesCopy[^2]} and {heroesCopy[^1]}";
                    heroesCopy.RemoveAt(heroesCopy.Count - 1);

                }
                return string.Join(", ", heroesCopy);
            }
        }



        static void Main(string[] args)
        {
            var heroes = new List<string>();
            heroes.Add("Jazlyn");
            heroes.Add("Theron");
            heroes.Add("Dayana");
            heroes.Add("Roberto");
            Console.WriteLine(JoinWithAnd(heroes, false));
        }
    }
}
