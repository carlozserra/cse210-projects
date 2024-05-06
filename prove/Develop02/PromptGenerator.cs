using System;

public class PromptGenerator
{
    private List<string> _prompt = new List<string>() {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompt.Count);
        return _prompt[randomIndex];
    }
}