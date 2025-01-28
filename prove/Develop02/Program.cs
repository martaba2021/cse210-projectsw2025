using System;
using System.Collections.Generic;

public class Program
{
    public List<Entry>_entries = new List<Entry>();
    static void Main(string[] args)
    {
        Program program = new Program();

            while (true)
            {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string choice = Console.ReadLine();
            int choiceSelected;

            try{

                choiceSelected = int.Parse(choice);

                if (choiceSelected == 1)
                {
                    program.GetRandomPrompt();
                }
                else if (choiceSelected == 2)
                {
                    program.DisplayListJournalEntry();
                }
                else if (choiceSelected == 3)
                {
                    program.LoadingDailyJournalEntry();
                }
                else if (choiceSelected == 4)
                {
                    program.SavingDailyJournalEntry();
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
            }          
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
            }
            }
        }
        public void LoadingDailyJournalEntry()
        {

        }

    }
}
