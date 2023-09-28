using System;

namespace Fractoral
{
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n == 0) return 1; 
            else return n * Factorial(n - 1);
        }
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));
        }
    }
}
