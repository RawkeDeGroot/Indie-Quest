using System;

namespace Seasons
{
    internal class Program
    {


        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter

        }

        static string[] Seasons = { "Spring", "Summer", "Autumn", "Winter" };

        static string createDayDescription(int dayNumber, Season season, int yearNumber)
        {
            
                int secondToLastDigit = 0;


                int lastDigit = dayNumber % 10;
                if (dayNumber >= 10)
                {
                    int n = dayNumber / 10;
                    secondToLastDigit = n % 10;
                }

                if (secondToLastDigit == 1)
                {
                    return $"{dayNumber}th of {Seasons[(int)season]} in the year {yearNumber}";

                }
                else if (lastDigit == 1)
                    return $"{dayNumber}st of {Seasons[(int)season]} in the year {yearNumber}";

                else if (lastDigit == 2)
                    return $"{dayNumber}nd of {Seasons[(int)season]} in the year {yearNumber}";

                else if (lastDigit == 3)
                    return $"{dayNumber}rd of {Seasons[(int)season]} in the year {yearNumber}";
                else return $"{dayNumber}th of {Seasons[(int)season]} in the year {yearNumber}";
        }

        static void Main(string[] args)
        {
            string dayDescription = createDayDescription(22, Season.Autumn, 2023);
            Console.WriteLine(dayDescription);
        }
    }
}
