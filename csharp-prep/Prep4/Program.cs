using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
               
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> addList = new List<int>();
        int numberList;

        do
        {  
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            numberList = int.Parse(userNumber);

            if (numberList != 0)
            {
                addList.Add(numberList);
            }
        }
        while (numberList != 0);
        
        int sum = 0;

        foreach (int number in  addList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}"); 

        float average = ((float)sum) / addList.Count;

        Console.WriteLine($"The average is: {average}");

        int max = addList [0];

        foreach (int number in addList)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}