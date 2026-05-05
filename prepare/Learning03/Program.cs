using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction = new Fraction();

        for (int i = 1; i <= 20; i++)
        {
            Random randomGenerator = new Random();
            double top = randomGenerator.Next(1, 30);
            double bottom = randomGenerator.Next(1, 30);
            
            fraction.SetNumerator(top);
            fraction.SetDenominator(bottom);

            Console.WriteLine($"Fraction {i}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue()}");
        }

        Fraction newfrac = new Fraction(3);
        Fraction other = new Fraction(5, 6);
    }
}