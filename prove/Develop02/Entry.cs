class Entry
{

    string date, prompt, response;

    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
    }
    public void WriteEntry()
    {
        using (StreamWriter OutputFile = new StreamWriter("journal.txt", true))
       {
           OutputFile.WriteLine($"Prompt: {prompt}");
           OutputFile.WriteLine($"Response: {response}");
           OutputFile.WriteLine("-------------------");
       }
    }

    public void DisplayEntry()
    {
           Console.WriteLine($"Prompt: {prompt}");
           Console.WriteLine($"Response: {response}");
           Console.WriteLine("-------------------");

    }
    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }
}