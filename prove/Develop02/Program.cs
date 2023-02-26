using System;

class Entry{
    public List<string> prompts = new List<string>();
    public string _prompt;
    public string message;
    public Entry()
    {
        prompts.Add("What made you smile today? ");
        prompts.Add("What was the best part of your day? ");
        prompts.Add("Who did you serve today? ");
        prompts.Add("What blessing are you grateful for today?");

        Random randomGenerator= new Random ();
        int promptNumber = randomGenerator.Next(1,4);
        _prompt = prompts[promptNumber];        
        
    }
    void writeEntry()

    {
       string userInput; 
       userInput = Console.ReadLine();
       Console.WriteLine(_prompt); 
       message = Console.ReadLine();

    }
    string getPrompt()
    {
        return _prompt;
    }


}
class Journal
{
    public string file ="Journal.txt";
    public void writeJournalEntry()
    {
        Entry entry = new Entry();
        entry.writeEntry(file);
    }

}
class Program
{

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.writeJournalEntry();
        //    public string _entry;
//    public List<Entry>entryList = new List<Entry>();
//    public void Display()
//    {
//        Console.WriteLine($"1. Write a new entry -");
//        Console.WriteLine($"2. Display the journal to a file - ");
//        Console.WriteLine($"3. Save the journal to a file - ");
//        Console.WriteLine($"4. Load the journal from a file - ");
//        foreach (Entry entry in _entry)
//        {
//            entry.Display();
//        }
//    }

    }
}