using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);*/

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

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
        while (guess != number);  
    }
}