using System;
using System.Globalization;

namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set the price: ");
            string price = Console.ReadLine();
            string[] Input = price.Split(' ');
            int x;
            int y;
            x = Int32.Parse(Input[0]);
            int result = 0;

            if (Input.Length > 1) 
            { 
                y = int.Parse(Input[2]);
                switch (Input[1]) 
                {
                    case "+":
                        result = x + y;
                        break;
                    case "-":
                        result = x - y;
                        break;
                    case "*":
                    case "x":
                        result = x * y;
                        break;
                    case "/":
                        result = x / y;
                        break;
                }
            }
            else
            {
                result = x;
            }
            Console.WriteLine($"The price was set to {result}");
        }
    }
}