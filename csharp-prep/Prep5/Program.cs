using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        int square = SquareNumber(favNumber);
        DisplayResults(userName, favNumber, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write($"Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }
    static int SquareNumber(int number)
    {
        return number * number;

    }
    static void DisplayResults(string userName, int favNumber, int number)
    {
        Console.WriteLine($"{userName}, the square of your number is {number}");
    }
}