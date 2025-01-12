using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int number = int.Parse(userGrade);
        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >=70)
        {
            letter = "C";
        }
        else if (number >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your final grade is: {letter}");
        
        /*if (number >= 90)
        {
        Console.WriteLine("Your final grade is A.");
        }
        else if (number >= 80)
        {
        Console.WriteLine("Your final grade is B.");
        }
        else if (number >= 70)
        {
        Console.WriteLine("Your final grade is C.");
        }
        else if (number >= 60)
        {          
        Console.WriteLine("Your final grade is D.");
        }
        else
        {             
        Console.WriteLine("Your final grade is F");
        }*/
        if (number >= 70) 
        {
            Console.Write("Congratulations you passed your class!");
        }     
        else 
        {
            Console.WriteLine("You did not pass, but try again!");
        }
    }
}