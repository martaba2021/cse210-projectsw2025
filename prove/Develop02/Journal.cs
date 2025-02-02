using System;
using System.Collections.Generic;
using System.IO;
// Create a Journal Class
public class Journal
{
    public List<Entry> _entries = new List<Entry>(); //list    
    private const string fileName = "journal.txt";
    public static string FileName => fileName;
    public void AddDailyJournalEntry(string prompt, string entryText) //method
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateTime = theCurrentTime.ToShortDateString();
        Entry entry = new Entry(dateTime, prompt, entryText);
        _entries.Add(entry);
        Console.WriteLine("What would you like to do next");
    }
    public void DisplayJournalEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._journalDateTime}");
            Console.WriteLine($"{entry._prompt}");
            Console.WriteLine($"{entry._dailyJournalEntry}");
        }
    }
    public void LoadDailyJournalEntry() //method
    {
        if (File.Exists(FileName))
        {
            using (StreamReader reader = new StreamReader(FileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] entryParts = line.Split('|');
                    if (entryParts.Length == 3)
                    {
                        string dateTime = entryParts[0].Trim();
                        string prompt = entryParts[1].Trim();
                        string entryText = entryParts[2].Trim();
                        Entry loadedEntry = new Entry(dateTime, prompt, entryText);
                        _entries.Add(loadedEntry);
                    }
                }
            }
            Console.WriteLine("Your journal entry has been saved.");
        }
        else
        {
            {
                Console.WriteLine("No journal file found.");
            }
        }
    }
    public void SaveDailyJournalEntry()
    {
        using (StreamWriter writer = new StreamWriter(FileName, append: true))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._journalDateTime} | {entry._prompt} | {entry._dailyJournalEntry}");
            }
            Console.WriteLine("Your entry has been saved.");
        }
    }
    
}
