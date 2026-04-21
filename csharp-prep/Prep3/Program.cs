using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        

        Random randomGenerator = new Random();
        int numMagic = randomGenerator.Next(1, 11);
        
        int guess = 0;

        while (guess != numMagic)
        {
            Console.Write("What is your guess? ");
            string response = Console.ReadLine();
            guess = int.Parse(response);

            if (numMagic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (numMagic < guess)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("You guessed it!");
    }
}