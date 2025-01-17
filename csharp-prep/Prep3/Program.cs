using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);
        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        int guess = int.Parse(guessNumber);

        if (guess > number)
        {
            Console.WriteLine("Lower.");
        }
        else if (guess < number )
        {
            Console.WriteLine("Higher.");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}