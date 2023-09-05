using System;

namespace Ordinal_numbers
{
    internal class Program
    {
        static string OrdinalNumber (int number)
        {
            int secondToLastDigit = 0;
            
            
            int lastDigit = number % 10;
            if (number >= 10) 
            {
                int n = number / 10;
                secondToLastDigit = n % 10;
            }

            if (secondToLastDigit == 1)
            {
                return $"{number}th";

            }
            else if (lastDigit == 1)
                return $"{number}st";

            else if (lastDigit == 2) 
                return $"{number}nd";

            else if (lastDigit == 3) 
                return $"{number}rd";
            else return $"{number}th";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(OrdinalNumber(121));
        }
    }
}
