using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

public class PromptGenerator
{
    public string _journalPromptGenerator; //field
        public string[] prompts = new string[]
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did you learn something new today?",
        "Were you able to complete your most important task? Why or why not?",
        "Was anyone kind to you or were you kind to someone? How?",
        "Describe something beautiful that you saw today.",
        "Was there any event today that reminded you of how far you have come and achieved your goals?",
        "What talents did you use today to help someone in need?"
        };
    public string GetRandomPrompt()   //method to get a random prompt
    {
       Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index]; 
    }
}