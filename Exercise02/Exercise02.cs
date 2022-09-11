using Exercise01;
using System;
using System.Numerics;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("Enter numeric");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (BigInteger.TryParse(input, out BigInteger bigInteger))
                    {
                        var inWords = bigInteger.Towards();
                        Console.WriteLine($"Number in words: {inWords}");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);

        }
    }
}