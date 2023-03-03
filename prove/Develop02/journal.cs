class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }

    }
    public void CreateJournalEntry()
    {
        PromptGenerator generator = new PromptGenerator();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string prompt = generator.GetRandomPrompt();
        // Create the logic to get the date, prompt and response.
        Entry entry = new Entry(dateText, prompt, "temp response");
        
    }
    public void SaveToCSV()
    {

    }
    public void LoadFromCSV()
    {

    }
    }


//    public string file ="Journal.txt";
//    public void writeJournalEntry()

//}



