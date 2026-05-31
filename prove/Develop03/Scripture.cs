public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());

        string displayText = "";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        Console.WriteLine(displayText);
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}