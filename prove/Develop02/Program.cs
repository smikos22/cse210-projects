using System;

class Entry{
    public List<string> prompts = new List<string>();
    public string prompt;
    public string message;
    public Entry()
    {
        prompts.Add("What made you smile today? ");
        prompts.Add("What was the best part of your day? ");
        prompts.Add("Who did you serve today? ");
        prompts.Add("What blessing are you grateful for today?");
        prompts.Add("If I had one thing I could do over today, what would it be? ");

        Random randomGenerator= new Random ();
        int promptNumber = randomGenerator.Next(0,5);
        prompt = prompts[promptNumber];        
        
    }
   public void writeEntry(String file)

    {
       Console.WriteLine(prompt); 
       message = Console.ReadLine();

       using (StreamWriter OutputFile = new StreamWriter(file, true))
       {
        OutputFile.WriteLine($"Promp: {prompt}");
        OutputFile.WriteLine($"Message: {message}");
        OutputFile.WriteLine("-------------------");
       }
    }
    string getPrompt()
    {
        return prompt;
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
       public string _entry;
       public List<Entry>entryList = new List<Entry>();
       public void Display()
       {
          Console.WriteLine($"1. Write a new entry -");
          Console.WriteLine($"2. Display the journal to a file - ");
          Console.WriteLine($"3. Save the journal to a file - ");
          Console.WriteLine($"4. Load the journal from a file - ");
          
      }

    }
