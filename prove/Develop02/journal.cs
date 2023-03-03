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
        // Create the logic to get the date, prompt and response.
        Entry entry = new Entry("temp date", "temp prompt", "temp response");

        entries.Add(entry);

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



