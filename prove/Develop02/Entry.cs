using System;

public class Entry
{
    public string _journalDateTime;  
    public string _prompt;  
    public string _dailyJournalEntry;

    public Entry(string journaldateTime, string prompt, string entryText)
    {
        _journalDateTime = journaldateTime;
        _dailyJournalEntry = entryText;
        _prompt = prompt;
    }
    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_journalDateTime}, {_prompt}:{_dailyJournalEntry}");
    }
}