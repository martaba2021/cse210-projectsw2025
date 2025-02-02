using System;

public class Entry
{
    public string _journalDateTime;    
    public string _dailyJournalEntry;
    internal object _journalPromptGenerator;

    public Entry(string dateTime, string prompt, string entryText)
    {
        _journalDateTime = dateTime;
        _dailyJournalEntry = entryText;
    }
    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_journalDateTime}: {_dailyJournalEntry}");
    }
}