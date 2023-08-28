using System;
using static System.Net.WebRequestMethods;

namespace Bowling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            
            int knockedPins1 = random.Next(0, 11);
            int pinsleft = 10 - knockedPins1;

            int knockedPins2 = random.Next(0, pinsleft + 1);

            int knockedPinsTotal = knockedPins1 + knockedPins2;

            string scoreText = $"First Roll: {knockedPins1}\nSecond Roll: {knockedPins2}";

            if (knockedPins1 == 10)
            {
                scoreText = $"First Roll: X";
            }

            if (knockedPinsTotal == 10 && knockedPins1 < 10)
            {
                scoreText = $"First Roll: {knockedPins1}\nSecond Roll: /";
            }

            Console.WriteLine(scoreText.Replace("0", "-"));
            Console.WriteLine($"Knocked Pins: {knockedPinsTotal}");
        }
    }
}