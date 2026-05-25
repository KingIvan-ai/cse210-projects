public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry();
        entry._date = date;
        entry._prompt = prompt;
        entry._response = response;

        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter a filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                writer.WriteLine($"{e._date}|{e._prompt}|{e._response}");
            }
        }

        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter a filename to load from: ");
        string filename = Console.ReadLine();

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded.");
    }

    public void SearchEntries()
    {
        Console.Write("Enter a keyword to search for: ");
        string keyword = Console.ReadLine();

        bool found = false;

        foreach (Entry e in _entries)
        {
            if (e._response.Contains(keyword) || e._prompt.Contains(keyword))
            {
                e.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No entries found with that keyword.");
        }
    }
}