using System;

public class Entry
{
    public string _journalDateTime;    
    public string _dailyJournalEntry;

    public Entry(string dateTime, string entryText)
    {
        _journalDateTime = dateTime;
        _dailyJournalEntry = entryText;
    }
    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_journalDateTime}: {_dailyJournalEntry}"):
    }
}