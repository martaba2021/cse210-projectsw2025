using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choiceSelected;

        do
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string choice = Console.ReadLine();
            bool validInput = int.TryParse(choice, out choiceSelected);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
            }

            switch (choiceSelected)
            {
                case 1:

                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine("Here is your prompt: ");
                Console.WriteLine(prompt);
                Console.WriteLine(" ");
                string entryText = Console.ReadLine();
                journal.AddDailyJournalEntry(entryText, prompt);
                break;

                case 2:

                journal.DisplayJournalEntries();
                break;

                case 3:
                journal.LoadDailyJournalEntry();
                break;

                case 4:
                journal.SaveDailyJournalEntry();
                break;

                case 5:
                Console.WriteLine("Goodbye");
                break;

                default:
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                break;
            }
        } 
        while (choiceSelected !=5);
    }          
}    
    
/*}
            else if (choiceSelected == 2)
            {
                journal.DisplayListJournalEntry();
            }
            else if (choiceSelected == 3)
            {
                journal.LoadDailyJournalEntry();
            }
            else if (choiceSelected == 4)
            {
                journal.SaveDailyJournalEntry();
            }
            else if (choiceSelected == 5)
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            while (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
            }
        }
        }
    
    
    
    
    /*static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(+prompt);
    }


}
*/
