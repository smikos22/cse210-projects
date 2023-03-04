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
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry(dateText, prompt, response);
        //SaveToCSV(entry);
        //LoadFromCSV();
 //       entry.WriteEntry();
        entries.Add(entry);
        
    }
    public void SaveToCSV()
    {
        using (StreamWriter file = new StreamWriter("Journal.csv"))
        {
            foreach (Entry entry in entries)
            {
                file.WriteLine(entry.getEntryAsCSV());
            }
        }
    }
    public void LoadFromCSV()
    {
        Console.WriteLine("Enter the File Name: ");
        string fileName = Console.ReadLine();
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fields = line.Split('|');
                Entry entry = new Entry(fields[0], fields[1], fields[2]);
                entries.Add(entry);
            }

        }
    }
    }


//    public string file ="Journal.txt";
//    public void writeJournalEntry()

//}



