using System;
using System.Linq.Expressions;

namespace Enums
{
    internal class Program

    {
        enum Suits
        {
            Hearts,     
            Diamonds,   
            Clubs,      
            Spades      
        }
        static void DrawAce(Suits suit)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            switch (suit)
            {
                case Suits.Hearts:
                    {
                        Console.WriteLine($"╭───────╮");
                        Console.WriteLine($"│A      │");
                        Console.WriteLine($"│♥      │");
                        Console.WriteLine($"│   ♥   │");
                        Console.WriteLine($"│      ♥│");
                        Console.WriteLine($"│      A│");
                        Console.WriteLine($"╰───────╯");
                        return;
                    }
                case Suits.Diamonds:
                    {
                        Console.WriteLine($"╭───────╮");
                        Console.WriteLine($"│A      │");
                        Console.WriteLine($"│♦      │");
                        Console.WriteLine($"│   ♦   │");
                        Console.WriteLine($"│      ♦│");
                        Console.WriteLine($"│      A│");
                        Console.WriteLine($"╰───────╯");
                        return;
                    }
                case Suits.Clubs:
                    {
                        Console.WriteLine($"╭───────╮");
                        Console.WriteLine($"│A      │");
                        Console.WriteLine($"│♣      │");
                        Console.WriteLine($"│   ♣   │");
                        Console.WriteLine($"│      ♣│");
                        Console.WriteLine($"│      A│");
                        Console.WriteLine($"╰───────╯");
                        return;
                    }
                case Suits.Spades:
                    {
                        Console.WriteLine($"╭───────╮");
                        Console.WriteLine($"│A      │");
                        Console.WriteLine($"│♠      │");
                        Console.WriteLine($"│   ♠   │");
                        Console.WriteLine($"│      ♠│");
                        Console.WriteLine($"│      A│");
                        Console.WriteLine($"╰───────╯");
                        return;
                    }

            }

        }
        static void Main(string[] args)
        {
            DrawAce(Suits.Spades);
        }
    }
}