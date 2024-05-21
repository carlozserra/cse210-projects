
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor to initialize the reference and split text into words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Method to hide a specified number of random words
    public void HideRandomWords(int numbersToHide)
    {
        Random rnd = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numbersToHide )
        {
            int randomIndex = rnd.Next(0, _words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    // Method to get the display text of the scripture
    public string GetDisplayText()
    {
        string displayText = _reference.ToString() + "\n";
       
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}


