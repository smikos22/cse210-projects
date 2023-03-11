/*class Scripture
{
    private List<List<Word>> _verses;

    public Reference Reference { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        string[] lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        _verses = new List<List<Word>>();
        foreach (string line in lines)
        {
            string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            _verses.Add(words.Select(w => new Word(w)).ToList());
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference);
        foreach (List<Word> verse in _verses)
        {
            foreach (Word word in verse)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }

    public bool HideRandomWord()
    {
        List<Word> allWords = _verses.SelectMany(v => v).ToList();
        List<Word> hiddenWords = allWords.Where(w => w.Hidden).ToList();
        if (hiddenWords.Count == allWords.Count)
        {
            return false;
        }
        Random rand = new Random();
        Word wordToHide;
        do
        {
            wordToHide = allWords[rand.Next(allWords.Count)];
        }
        while (wordToHide.Hidden);
            wordToHide.Hidden = true;
        return true;
    }
}*/